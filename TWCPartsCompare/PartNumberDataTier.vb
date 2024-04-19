'Title:         Part Number Data Tier
'Date:          2-13-15
'Author:        Terry Holmes

'Description:   This is the data tier for all part numbers

Public Class PartNumberDataTier

    Private aPartNumberIDDataSetTableAdapters As PartNumberIDDataSetTableAdapters.PartNumberIDTableAdapter
    Private aPartNumberIDDataSet As PartNumberIDDataSet

    Private aPartNumbersDataSetTableAdapters As PartNumbersDataSetTableAdapters.partnumbersTableAdapter
    Private aPartNumbersDataSet As PartNumbersDataSet

    Private aPartNumberComparisonDataSetTableAdapters As PartNumberComparisonDataSetTableAdapters.partnumberscomparisonTableAdapter
    Private aPartNumberComparisonDataSet As PartNumberComparisonDataSet

    Public Function GetPartNumberComparisonInformation() As PartNumberComparisonDataSet

        'Setting up the Datatier
        Try
            aPartNumberComparisonDataSet = New PartNumberComparisonDataSet
            aPartNumberComparisonDataSetTableAdapters = New PartNumberComparisonDataSetTableAdapters.partnumberscomparisonTableAdapter
            aPartNumberComparisonDataSetTableAdapters.Fill(aPartNumberComparisonDataSet.partnumberscomparison)
            Return aPartNumberComparisonDataSet

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Check", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aPartNumberComparisonDataSet
        End Try
    End Function

    Public Function GetPartNumbersInformation() As PartNumbersDataSet

        'Setting up the Datatier
        Try
            aPartNumbersDataSet = New PartNumbersDataSet
            aPartNumbersDataSetTableAdapters = New PartNumbersDataSetTableAdapters.partnumbersTableAdapter
            aPartNumbersDataSetTableAdapters.Fill(aPartNumbersDataSet.partnumbers)
            Return aPartNumbersDataSet

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Check", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aPartNumbersDataSet
        End Try
    End Function

    Public Sub UpdatePartNumbersDB(ByVal aPartNumbersDataSet As PartNumbersDataSet)

        'This will update the database
        Try
            aPartNumbersDataSetTableAdapters.Update(aPartNumbersDataSet.partnumbers)
        Catch ex As Exception

        End Try

    End Sub


    Public Sub UpdatePartNumberComparisonDB(ByVal aPartNumberComparisonDataSet As PartNumberComparisonDataSet)

        'This will update the database
        Try
            aPartNumberComparisonDataSetTableAdapters.Update(aPartNumberComparisonDataSet.partnumberscomparison)
        Catch ex As Exception

        End Try

    End Sub

    Public Function GetPartNumberIDInformation() As PartNumberIDDataSet

        'Setting up the Datatier
        Try
            aPartNumberIDDataSet = New PartNumberIDDataSet
            aPartNumberIDDataSetTableAdapters = New PartNumberIDDataSetTableAdapters.PartNumberIDTableAdapter
            aPartNumberIDDataSetTableAdapters.Fill(aPartNumberIDDataSet.PartNumberID)
            Return aPartNumberIDDataSet

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Check", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aPartNumberIDDataSet
        End Try
    End Function

    Public Sub UpdatePartNumberIDDB(ByVal aPartNumberIDDataSet As PartNumberIDDataSet)

        'This will update the database
        Try
            aPartNumberIDDataSetTableAdapters.Update(aPartNumberIDDataSet.PartNumberID)
        Catch ex As Exception

        End Try
    End Sub


End Class
