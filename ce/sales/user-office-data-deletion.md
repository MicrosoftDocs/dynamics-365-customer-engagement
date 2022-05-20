For GDPR Deletion

Deletion Request
POST request
Request URL:
{orgUrl}/api/data/v9.1/msdyn_WKWDeleteGDPRData
Body: {"UserIds": List of system userid’s}
Ex: {"UserIds": ["3671fb10-d6d0-ec11-a7b6-000d3a5bc91c", "5571fb10-d6d0-ec11-a7b6-000d3a5bc91c"]}

Response contains no content with HTTP 204 

Check Deletion Request Status
For checking status of deletion request made
POST request
Request URL:
{orgUrl}/api/data/v9.1/msdyn_WKWGDPRDeleteStatus
Body: {"UserIds": List of system userid’s}
Ex: {"UserIds": ["3671fb10-d6d0-ec11-a7b6-000d3a5bc91c", "5571fb10-d6d0-ec11-a7b6-000d3a5bc91c"]}

Response Contains: 
{
UsersWithRequest:[{“SystemUserId” : Systemuser id, “Status”: can be PROCESSING, COMPLETED or FAILED}],
UsersWithNoRequest: List of systemuser ids provided for status check, but have no GDPR delete request for them
} 

{
    "@odata.context": https://org4cc4a79a.crm10.dynamics.com/api/data/v9.1/$metadata#Microsoft.Dynamics.CRM.msdyn_WKWGDPRDeleteStatusResponse,
    "Response": "{\"UsersWithRequest\":[{\"SystemUserId\":\"3671fb10-d6d0-ec11-a7b6-000d3a5bc91c\",\"Status\":\"PROCESSING\"},{\"SystemUserId\":\"5571fb10-d6d0-ec11-a7b6-000d3a5bc91c\",\"Status\":\"PROCESSING\"}],\"UsersWithNoRequest\":[]}"
}



For Export:
They can make an OData call to entities msdyn_wkwcolleaguesforcompanies and msdyn_wkwcolleaguesforcontacts with corresponding system user id’s

Example:

{orgUrl}/api/data/v9.0/msdyn_wkwcolleaguesforcontacts?$filter=msdyn_introducer_systemuserid/systemuserid eq c8fe6e3c-90cf-ec11-a7b6-002248304f49

{orgurl}/api/data/v9.0/msdyn_wkwcolleaguesforcompanies?$filter=msdyn_introducer_systemuserid/systemuserid eq c8fe6e3c-90cf-ec11-a7b6-002248304f49
