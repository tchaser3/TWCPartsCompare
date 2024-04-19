'Title:         Part Number Comparison
'Date:          2-13-15
'Author:        Terry Holmes

'Description:   This form will process the compare

Option Strict On

Public Class Form1

    'Setting up Part Number
    Private ThePartNumbersDataSet As PartNumbersDataSet
    Private ThePartNumbersDataTier As PartNumberDataTier
    Private WithEvents ThePartNumbersBindingSource As BindingSource

    'Setting up the warehouse Inventory
    Private TheWarehouseInventoryDataSet As WarehouseInventoryDataSet
    Private TheWarehouseInventoryDataTier As WarehouseInventoryDataTier
    Private WithEvents TheWarehouseInventoryBindingSource As BindingSource

    'Setting up the Received Parts Data components
    Private TheReceivePartsDataSet As ReceivePartsDataSet
    Private TheReceivePartsDataTier As ReceivePartsDataTier
    Private WithEvents TheReceivePartsBindingSource As BindingSource

    Private TheBOMPartsDataSet As BOMPartsDataSet
    Private TheBOMPartsDataTier As BOMPartsDataTier
    Private WithEvents TheBOMPartsBindingSource As BindingSource

    'Setting up classes
    Dim TheInputDataValidation As New InputDataValidation
    Dim TheKeyWordSearch As New KeyWordSearchClass
    Dim TheModuleUnderDevelopment As New ModuleUnderDevelopment

    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False
    Private previousSelectedIndex As Integer

    Dim mstrTWCPartNumbers() As String
    Dim mintTWCPartCounter As Integer
    Dim mintTWCPartUpperLimit As Integer

    Dim mstrNewTWCPartNumbers() As String
    Dim mintNewTWCPartCounter As Integer
    Dim mintNewTWCPartUpperLimit As Integer

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        CloseProgram.ShowDialog()

    End Sub
    Private Sub ClearTransactionDataBindings()

        'this will clear the data bindings
        cboTransactionPartID.DataBindings.Clear()
        txtTransactionPartDescription.DataBindings.Clear()
        txtTransactionPartNumber.DataBindings.Clear()

    End Sub
    Private Sub ClearMainDataBingins()

        'this will clear the main databindings
        cboMainPartID.DataBindings.Clear()
        txtMainActive.DataBindings.Clear()
        txtMainPartDescription.DataBindings.Clear()
        txtMainPartNumber.DataBindings.Clear()
        txtMainPrice.DataBindings.Clear()
        txtMainTWCPart.DataBindings.Clear()

    End Sub
    Private Sub SetTransactionControlsVisible(ByVal ValueBoolean As Boolean)

        'This will allow the controls to be seen
        cboTransactionPartID.Visible = ValueBoolean
        txtTransactionPartDescription.Visible = ValueBoolean
        txtTransactionPartNumber.Visible = ValueBoolean

    End Sub
    Private Sub SetMainDataBindings()

        Try

            'Setting up the main controls
            ThePartNumbersDataTier = New PartNumberDataTier
            ThePartNumbersDataSet = ThePartNumbersDataTier.GetPartNumbersInformation
            ThePartNumbersBindingSource = New BindingSource

            'Setting up the bindingsource
            With ThePartNumbersBindingSource
                .DataSource = ThePartNumbersDataSet
                .DataMember = "partnumbers"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboMainPartID
                .DataSource = ThePartNumbersBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("text", ThePartNumbersBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'Setting up the rest of the controls
            txtMainActive.DataBindings.Add("text", ThePartNumbersBindingSource, "Active")
            txtMainPartDescription.DataBindings.Add("text", ThePartNumbersBindingSource, "Description")
            txtMainPartNumber.DataBindings.Add("text", ThePartNumbersBindingSource, "PartNumber")
            txtMainTWCPart.DataBindings.Add("text", ThePartNumbersBindingSource, "TimeWarnerPart")

        Catch ex As Exception

            'Message to user that there is a problem
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This will load when the application does
        SetMainDataBindings()
        SetTransactionControlsVisible(False)

    End Sub
    Private Sub LoadTWCPartArray()

        'Setting local variables
        Dim intCounter As Integer
        Dim intNumberOfRecords As Integer
        Dim strPartNumberForArray As String
        Dim intPartNumberForArray As Integer
        Dim blnFatalError As Boolean

        'Setting up for loop
        intNumberOfRecords = cboMainPartID.Items.Count - 1
        ReDim mstrTWCPartNumbers(intNumberOfRecords)
        mintTWCPartCounter = 0

        'Beginning loop
        For intCounter = 0 To intNumberOfRecords

            'Setting boolean modifier
            blnFatalError = False

            'incrementing the combo box
            cboMainPartID.SelectedIndex = intCounter

            'loading up variables
            strPartNumberForArray = txtMainPartNumber.Text

            'Checking to see if part number is numeric
            blnFatalError = TheInputDataValidation.VerifyData(strPartNumberForArray)

            'If statements for filling the array
            If blnFatalError = False Then

                'Setting up the integer for if statements
                intPartNumberForArray = CInt(txtMainPartNumber.Text)

                If intPartNumberForArray >= 1000000 And intPartNumberForArray <= 9999999 Then

                    mstrTWCPartNumbers(mintTWCPartCounter) = strPartNumberForArray
                    mintTWCPartCounter += 1

                End If
            End If
        Next

        'Completing the routine
        mintTWCPartUpperLimit = mintTWCPartCounter - 1
        mintTWCPartCounter = 0

    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click

        'Setting Local Variables
        Dim intNumberOfRecords As Integer

        'This will process the data
        mintNewTWCPartCounter = 0
        mintNewTWCPartUpperLimit = 0
        LoadTWCPartArray()
        SetTransactionControlsVisible(True)
        ClearTransactionDataBindings()
        LoadWarehouseInventoryDataBindings()
        intNumberOfRecords = cboTransactionPartID.Items.Count - 1
        ReDim mstrNewTWCPartNumbers(intNumberOfRecords)
        ComparePartNumbers()
        ClearTransactionDataBindings()
        LoadReceivePartsDataBindings()
        ComparePartNumbers()
        ClearTransactionDataBindings()
        LoadBOMPartsDataBindings()
        ComparePartNumbers()

    End Sub
    Private Sub ComparePartNumbers()

        'Setting local variables
        Dim intMainCounter As Integer
        Dim intNewPartArray As Integer
        Dim intTransactionCounter As Integer
        Dim intTransactionNumberOfRecords As Integer
        Dim strPartNumberForSearch As String
        Dim strPartNumberFromTable As String
        Dim blnItemNotFound As Boolean

        'Setting up for loop
        intTransactionNumberOfRecords = cboTransactionPartID.Items.Count - 1

        'Performing Loop
        For intTransactionCounter = 0 To intTransactionNumberOfRecords

            'Setting boolean modifier
            blnItemNotFound = True

            'incrementing the counter
            cboTransactionPartID.SelectedIndex = intTransactionCounter

            'Getting part number
            strPartNumberForSearch = txtTransactionPartNumber.Text

            'Performing second loop
            For intMainCounter = 0 To mintTWCPartUpperLimit

                strPartNumberFromTable = mstrTWCPartNumbers(intMainCounter)

                If strPartNumberForSearch = strPartNumberFromTable Then
                    blnItemNotFound = False
                End If
            Next

            'Third loop
            For intNewPartArray = 0 To mintNewTWCPartUpperLimit

                'Getting part number
                strPartNumberFromTable = mstrNewTWCPartNumbers(intNewPartArray)

                If strPartNumberForSearch = strPartNumberFromTable Then
                    blnItemNotFound = False
                End If

            Next

            If blnItemNotFound = True Then
                mstrNewTWCPartNumbers(mintNewTWCPartCounter) = strPartNumberForSearch
                mintNewTWCPartCounter += 1
                mintNewTWCPartUpperLimit += 1
                CreateNewPartNumbers()
            End If
        Next

    End Sub
    Private Sub CreateNewPartNumbers()

        'This will save the record
        Try

            With ThePartNumbersBindingSource
                .EndEdit()
                .AddNew()
            End With

            'Setting up variables
            addingBoolean = True
            setComboBoxBinding()
            CreatePartNumberID.Show()
            cboMainPartID.Text = CStr(Logon.mintPartID)
            txtMainPartDescription.Text = txtTransactionPartDescription.Text
            txtMainPartNumber.Text = txtTransactionPartNumber.Text
            txtMainActive.Text = "YES"
            txtMainTWCPart.Text = "YES"
            txtMainPrice.Text = "0"

            'Saving the record
            ThePartNumbersBindingSource.EndEdit()
            ThePartNumbersDataTier.UpdatePartNumbersDB(ThePartNumbersDataSet)
            addingBoolean = False
            editingBoolean = False
            setComboBoxBinding()

        Catch ex As Exception

            'Message to user if there is a problem
            MessageBox.Show(ex.Message, "Please Correct Saving Record", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub setComboBoxBinding()
        With Me.cboMainPartID
            If (addingBoolean Or editingBoolean) Then
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.OnValidation
                .DropDownStyle = ComboBoxStyle.Simple
            Else
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.Never
                .DropDownStyle = ComboBoxStyle.DropDownList
            End If
        End With
    End Sub
    Private Sub LoadWarehouseInventoryDataBindings()

        'Try Catch for exceptions
        Try

            'Setting data variables
            TheWarehouseInventoryDataTier = New WarehouseInventoryDataTier
            TheWarehouseInventoryDataSet = TheWarehouseInventoryDataTier.GetWarehouseInventoryInformation
            TheWarehouseInventoryBindingSource = New BindingSource

            'Setting up the binding source
            With TheWarehouseInventoryBindingSource
                .DataSource = TheWarehouseInventoryDataSet
                .DataMember = "WarehouseInventory"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboTransactionPartID
                .DataSource = TheWarehouseInventoryBindingSource
                .DisplayMember = "PartID"
                .DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartID", False, DataSourceUpdateMode.Never)
            End With

            'Setting the rest of the controls
            txtTransactionPartDescription.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartDescription")
            txtTransactionPartNumber.DataBindings.Add("text", TheWarehouseInventoryBindingSource, "PartNumber")

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub LoadReceivePartsDataBindings()

        'Try Catch for exceptions
        Try

            'Setting data variables
            TheReceivePartsDataTier = New ReceivePartsDataTier
            TheReceivePartsDataSet = TheReceivePartsDataTier.GetReceivePartsInformation
            TheReceivePartsBindingSource = New BindingSource

            'Setting up the binding source
            With TheReceivePartsBindingSource
                .DataSource = TheReceivePartsDataSet
                .DataMember = "ReceivedParts"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboTransactionPartID
                .DataSource = TheReceivePartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheReceivePartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting the rest of the controls
            txtTransactionPartNumber.DataBindings.Add("text", TheReceivePartsBindingSource, "PartNumber")
            txtTransactionPartDescription.Text = ""

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub LoadBOMPartsDataBindings()

        'Try Catch for exceptions
        Try

            'Setting data variables
            TheBOMPartsDataTier = New BOMPartsDataTier
            TheBOMPartsDataSet = TheBOMPartsDataTier.GetBOMPartsInformation
            TheBOMPartsBindingSource = New BindingSource

            'Setting up the binding source
            With TheBOMPartsBindingSource
                .DataSource = TheBOMPartsDataSet
                .DataMember = "BOMParts"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboTransactionPartID
                .DataSource = TheBOMPartsBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheBOMPartsBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Setting the rest of the controls
            txtTransactionPartNumber.DataBindings.Add("text", TheBOMPartsBindingSource, "PartNumber")
            txtTransactionPartDescription.Text = ""

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
End Class
