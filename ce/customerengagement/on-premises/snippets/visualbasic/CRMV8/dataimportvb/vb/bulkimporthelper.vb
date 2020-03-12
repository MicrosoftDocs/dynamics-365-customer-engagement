' <snippetbulkimporthelper>


Imports System.IO
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query

Namespace Microsoft.Crm.Sdk.Samples
    Public NotInheritable Class BulkImportHelper
        ''' <summary>
        ''' Reads data from the specified .csv file
        ''' </summary>
        ''' <param name="filePath"></param>
        ''' <returns></returns>
        Private Sub New()
        End Sub
        Public Shared Function ReadCsvFile(ByVal filePath As String) As String
            Dim data As String = String.Empty
            Using reader As New StreamReader(filePath)
                Dim value As String = reader.ReadLine()
                Do While value IsNot Nothing
                    data &amp;= value
                    data &amp;= vbLf
                    value = reader.ReadLine()
                Loop
            End Using
            Return data
        End Function

        ''' <summary>
        ''' Reads data from the specified .xml file
        ''' </summary>
        ''' <param name="filePath"></param>
        ''' <returns></returns>
        Public Shared Function ReadXmlFile(ByVal filePath As String) As String
            Dim data As String = String.Empty
            Using reader As New StreamReader(filePath)
                data = reader.ReadToEnd()
            End Using
            Return data
        End Function

        ''' <summary>
        ''' Check for importlog records.
        ''' </summary>
        ''' <param name="service"></param>
        ''' <param name="importFileId"></param>
        Public Shared Sub ReportErrors(ByVal serviceProxy As OrganizationServiceProxy,
                                       ByVal importFileId As Guid)
            Dim importLogQuery As New QueryByAttribute()
            importLogQuery.EntityName = ImportLog.EntityLogicalName
            importLogQuery.ColumnSet = New ColumnSet(True)
            importLogQuery.Attributes.Add("importfileid")
            importLogQuery.Values.Add(New Object(0) {})
            importLogQuery.Values(0) = importFileId

            Dim importLogs As EntityCollection = serviceProxy.RetrieveMultiple(importLogQuery)

            If importLogs.Entities.Count > 0 Then
                Console.WriteLine("Number of Failures: " &amp; importLogs.Entities.Count.ToString())
                Console.WriteLine("Sequence Number    Error Number    Description    Column Header    Column Value   Line Number")

                ' Display errors.
                For Each log As ImportLog In importLogs.Entities
                    Console.WriteLine(String.Format("Sequence Number: {0}" _
                                                    &amp; vbLf &amp; "Error Number: {1}" _
                                                    &amp; vbLf &amp; "Description: {2}" _
                                                    &amp; vbLf &amp; "Column Header: {3}" _
                                                    &amp; vbLf &amp; "Column Value: {4}" _
                                                    &amp; vbLf &amp; "Line Number: {5}",
                                                    log.SequenceNumber.Value,
                                                    log.ErrorNumber.Value,
                                                    log.ErrorDescription,
                                                    log.HeaderColumn,
                                                    log.ColumnValue,
                                                    log.LineNumber.Value))
                Next log
            End If
        End Sub

        ''' <summary>
        ''' Waits for the async job to complete.
        ''' </summary>
        ''' <param name="asyncJobId"></param>
        Public Shared Sub WaitForAsyncJobCompletion(ByVal serviceProxy As OrganizationServiceProxy,
                                                    ByVal asyncJobId As Guid)
            Dim cs As New ColumnSet("statecode", "statuscode")
            Dim asyncjob As AsyncOperation =
                CType(serviceProxy.Retrieve("asyncoperation", asyncJobId, cs), AsyncOperation)

            Dim retryCount As Integer = 100

            Do While asyncjob.StateCode.Value <> AsyncOperationState.Completed AndAlso retryCount > 0
                asyncjob = CType(serviceProxy.Retrieve("asyncoperation", asyncJobId, cs), 
                    AsyncOperation)
                System.Threading.Thread.Sleep(2000)
                retryCount -= 1
                Console.WriteLine("Async operation state is " _
                                  &amp; asyncjob.StateCode.Value.ToString())
            Loop

            Console.WriteLine("Async job is " _
                              &amp; asyncjob.StateCode.Value.ToString() _
                              &amp; " with status " _
                              &amp; (CType(asyncjob.StatusCode.Value, 
                                 asyncoperation_statuscode)).ToString())
        End Sub
    End Class
End Namespace

' </snippetbulkimporthelper>