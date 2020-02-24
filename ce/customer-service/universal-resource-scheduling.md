---
title: Search Resource Availability and Create Bookings for Requirement Groups in Universal Resource Scheduling in Dynamics 365 Customer Service | Microsoft Docs
description: See how you can effectively search resource availability and create bookings for requirement groups in universal resource scheduling in the Customer Service Hub.
author: lerobbin
ms.author: lerobbin
manager: shujoshi
ms.date: 02/12/2020
ms.topic: article
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---
# Search Resource Availability and Create Bookings   

The Search Resource Availability API for requirement groups, and Create Requirement Group Bookings API creates the booking records for requirement groups. 

- Use the <b>Search Resource Availability for Requirement Group</b> API to return available resources slots when searched with requirement groups.
- Use the <b>Create Requirement Group Bookings</b> API to generate booking records for these requirement groups using the available resources slots.

At a high level, you pass the details of a requirement group to the API and retrieve a list of available resources and timeslots. This is helpful for self-scheduling scenarios where a user wants to query availability, or for portal scheduling scenarios where a customer wants to view availability of desired resources from a web site or app.   

### Prerequisites
- Dynamics 365 Organization 9.0+ with Universal Resource Scheduling 3.12.x.x version.

## Search Resource Availability for Requirement Group API input / output parameters

Use the following input and output parameters below for the Search Resource Availability For Requirement Group (<b> msdyn_SearchResourceAvailabilityForRequirementGroup</b>) API:

### Input parameters
|   |   |
|-----------------|--|--|
|Version (String) |  |Required|
|RequirementGroup(EntityReference)| |Required|
|RequirementSpecification (ResourceRequirement)|Duration (Intger)| Optional, if left null will respect targeting RequirementGroup Duration/start/End by default|
|  |Start (DateTime)|Optional, if left null will respect targeting RequirementGroup Duration/start/End by default |
|  |End (DateTime)  |Optional, if left null will respect targeting RequirementGroup Duration/start/End by default |
|  |Fullfillment Preference (Entity Refrence)|Optional, respect interval/ResultsPerintervals fields only, if left null will respect targeting Requirement Groups's interval/ResultPerinterval|
|Settings (Settings)|SortOption (Integer)| Optional|
| |ConsiderSlotsWithOverlappingBooking (Boolean)|Optional, False by default|
| |ConsiderSlotsWithProposedBooking (Boolean)|Optional, False by default|
| |ConsiderSlotsWithLessThanRequiredDuration (Boolean)|Optional, False by default|
| |PageSize (Intger)|Optional|
| |PageNumber (Intger)|Optional|
| |PageCookie (String)|Optional|
| |OrganizationUnits (List<<Guide>Guide>)|Optional|
| |RequiredSources (List<<Guide>Guide>)|Optional|

### Output parameters
| |  |
|-|--|
|Timeslot |StartTime (DateTime)                  |
|         |EndTime (DateTime)                    |
|         |ArrivalTime (DateTime)                |
|         |Effort (Double)                       |
|         |IsDuplicate (Boolean)                 |
|         |Resource (Resource)                   |
|         |Location (TimeSlotLocation)           |
|         |TimeGroup (TimeSlotTimeGroup)         |
|         |AvailableIntervals (List<<Guide>OutputTimeSlot>)|
|Resource |Resource (EntityReferece)|
|         |BusinessUnit (EntityReference) |
|         |OrganizationUnit (EntityReference) |
|         |ResourceType (Int)                 |
|         |PoolID (Guid)                      |
|         |CrewID (Guid)                      |
|         |Email (String)                     |
|         |Phone (String)                     |
|         |ImagePath (String)                 |
|Requirements|Requirement (EntityReference)   |
|            |ConstrainBag (String)           |
|            |Resource (List<<EntityReference>EntityReference>)   |
|ProposalResourceAssignmentSet|IntervalStart (DateTime)|
|   |ProposalResourceAssignment (List<<OutputProposalResourceGroup>OutputProposalResourceGroup>)|
|Paginginfos |MoreResults (Boolean)|
|            |PagingCookie (String)|


## Create Requirement Group Bookings API input / output parameters

Use the following input and output parameters below for the Create Requirement Group Bookings (<b> msdyn_CreateRequirementGroupBookings</b>) API:

### Input parameters
|                                  |   |         |
|----------------------------------|---|---------|
|Version (String)                  |   |Required |
|RequirementGroup (EntityReference)|   |Required |
|Start (DateTime)                  |   |Required |
|Duration (Int)                    |   |Required |
|ResourceAssignments (EntityCollection)|Requirement (Guid)|Required|
|<li> Resource (Guid)                  | |Required|
|<li> BookingStatusID (Guid)           | |Required|
|<li> Effort (Int)                     | |Required|
|<li> TravelTime (double)              | |Required|

### Output parameters
HandlerExecuted (Boolean)

## Using Requirement Group API

Next, we'll use the following scenario to walk through how to schedule a Requirement Group via API.  You will need a service created with resources before you can schedule a booking. Use following steps to create a service activity.   

### Service Configuration 

![Service Configuration ](media\ur-scheduling-1-new.png)

  1. In site map, under Scheduling, select <b>Service</b>
  2. Go to <b>Resource Requirements</b>
  3. Create a service activity, for this example we've created <b>Test Requirement Group</b>

### Service Activity Configuration  

![Service Activity Configuration](media\ur-scheduling-2-new.png)

  4. In site map, under Scheduling, select <b>Service Activities</b>
  5. Go to <b>Service Activities</b>
  6. Subject <b>Test Requirement Group</b>
  7. Service <b>Test Requirement Group</b>

> [!NOTE]
> This will  auto create a resource requirement group which will have the same name as service activity. 

Now you have a requirement group automatically created which has one technicians(resources) to be scheduled to perform service at your customer’s location. 

### Resource Requirement Group Grid 

Below is an example configuration of the Resource Requirement Group page: 

![Resource Requirement Group Grid](media\ur-scheduling-3-new.png)

1. Active Requirements Group

 > [!NOTE] 
 > To access the <b>Requirement Group</b> page from the Customer Service Hub (CSH) app, you will need to navigate there via a URL. 

> [!IMPORTANT]
> Use the following URL to reach the <b>Resource Requirements Group</b> page: <<YourOrgURL>YourOrgURL>?appid=guid&pagetype=entitylist&etn=msdyn_requirementgroupr.

2. Test Requirements Group

![Resource Requirement Group Grid](media\ur-scheduling-4-new.png)

3. Go to <b>General</b>
4. Name field <b>Test Requirement Group </b>
5. Enter name in <b>Owner</b> field 
6. Template field
7. Template Required, select <b>No </b>

### Search against your organization

In this next scenario, we show how to pass values for a specific Requirement Group (Entity Reference - GUID), Required Resources to complete work and match the Resource to the Organizational Unit.      

> [!IMPORTANT] 
> - To run API, you need GUIDs for:<BR>
>   - requirement group<BR>
>   - bookable resources<BR>
>   - organizational unit (which can be retrieve 
> using the [Web API](https://docs.microsoft.com/en-us/powerapps/developer/common-data-service/webapi/query-metadata-web-api))
> - If the API is called from a client (browser or canvas app) based on JavaScript, you need to have the extended SOAP SDK which is provided in the sample files for download. The extended SOAP SDK is not a Microsoft official release, but is provided in the sample for guidance. 
> - We recommend you test in your development or test environments to validate your scenario(s) and results before running in production environments.

To execute this search against your organization, you need to download the [sample files](https://go.microsoft.com/fwlink/?linkid=2117045). Once sample code is downloaded, follow the steps below:   

1. Modify the hard-coded input parameters in the msdyn_SearchResourceAvailabilityForRequirementGroupSample.js file to reflect the GUIDs of records in your org. (Example: requirement group, resources, Organizational unit).    

![Modify the hard-coded input parameters](media\ur-scheduling-5.PNG)

[Sample Search Requirement Group](https://go.microsoft.com/fwlink/?linkid=2117045)

2. Add the files in the sample folder as web resources in your organization 

![Modify the hard-coded input parameters](media\ur-scheduling-6-new.png)

![Modify the hard-coded input parameters](media\ur-scheduling-7-new.PNG)

3. Navigate to the newly added new_msdyn_SearchResourceAvailabilityForRequirementGroupSample.htm page. Example: <<YourOrgURL>>//WebResources/new_msdyn_SearchResourceAvailabilityForRequirementGroupSample.htm   

![Modify the hard-coded input parameters](media\ur-scheduling-8.PNG)

4. Open the browser’s developer tools using the F12 function key. Set breakpoints as needed and inspect the request/responses in the developer tool’s console.  

![Modify the hard-coded input parameters](media\ur-scheduling-9.PNG)

  We can see there are multiple sets of time slots that are returned with each Set corresponding to a matching available Resource mapped to the underlying Requirement of the Requirement Group.   

  Once the timeslot Sets are returned by the API, you can display them on your custom web portal, app or a Power app (model/canvas).    

5. Once you choose a specific timeslot set, (example: we chose Set number 1), update your new_msdyn_CreateRequirementGroupBookingsSample.js web resource in your org to pass the Resource Assignments (Requirement guid, Resource guid) and the Requirement Group per the example below:    

![Modify the hard-coded input parameters](media\ur-scheduling-10-new.PNG)

[Code Sample Create Requirement Group](https://go.microsoft.com/fwlink/?linkid=2117045)  

![Modify the hard-coded input parameters](media\ur-scheduling-11-new.png)

6. Navigate to the newly added new_ msdyn_CreateRequirementGroupBookingsSample.htm page. (Example: <<YourOrgURL>>//WebResources/new_msdyn_CreateRequirementGroupBookingsSample.htm) to invoke a call the Booking API and create the Booking   

![Modify the hard-coded input parameters](media\ur-scheduling-12.png)

7. Open the browser’s developer tools using F12 function key. Here you will see the Handler executed value is set to True indicating that the Bookings are created successfully.    

![Modify the hard-coded input parameters](media\ur-scheduling-13.png)

  We can also verify this by going back into the organization and checking the Associated bookings of the Service/Requirement group we created as shown below.    

![Modify the hard-coded input parameters](media\ur-scheduling-14-new.png)

![Modify the hard-coded input parameters](media\ur-scheduling-15-new.png)

Other possible scenarios that could leverage these APIs are:   
- Build a custom web app or a Dynamics 365 portal to provide appointment scheduling for end users to show available time slots for the service/product being offered using multi-resource requirements (requirement groups).
- Build a PowerApp canvas app to support self-scheduling scenarios for their line-of-business apps.    

## Additional Resources  

- Multiresource scheduling with [Requirement Groups](https://docs.microsoft.com/en-us/dynamics365/common-scheduler/multi-resource-scheduling-requirement-groups)
   
- Search Resource Availability API for [Single requirements](https://cloudblogs.microsoft.com/dynamics365/it/2019/07/15/how-to-use-resource-schedulings-search-resource-availability-api/)   

- [Docs](https://nam06.safelinks.protection.outlook.com/?url=https%3A%2F%2Fdocs.microsoft.com%2Fen-us%2Fdynamics365%2Fcustomer-engagement%2Ffield-service%2Foverview&data=04%7C01%7Csampatn%40microsoft.com%7Ce1790d48561843c259a208d6f0eed4a5%7C72f988bf86f141af91ab2d7cd011db47%7C1%7C0%7C636961305974176099%7CUnknown%7CTWFpbGZsb3d8eyJWIjoiMC4wLjAwMDAiLCJQIjoiV2luMzIiLCJBTiI6Ik1haWwiLCJXVCI6Mn0%3D%7C-1&sdata=WXpIMdyYkg4P0Niy1NKOi%2FjM%2F3fKqI2m4Ika6N5R0HA%3D&reserved=0): The primary documentation for Dynamics 365 for Field Service.   

- [Scheduling Docs](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/common-scheduler/schedule-anything-with-universal-resource-scheduling): Documentation for Resource Scheduling.   

- [Learn](https://docs.microsoft.com/en-us/learn/paths/universal-resource-scheduling/): Learning path for Resource Scheduling.   

- [Field Service YouTube Channel](https://www.youtube.com/playlist?list=PLcakwueIHoT_AQBxkQQ7zePzd7fzZYP7X): Includes concept videos for Field Service.   

- [Ideas](https://experience.dynamics.com/ideas/categories/list/?category=a2fa5aca-3f2d-e811-813c-e0071b6ad011&forum=bee3d862-df65-e811-a95d-000d3a1be7ad): The portal where you can contribute product feedback and ideas for Resource Scheduling.   

- [Forum](https://community.dynamics.com/365/fieldservice): Go here to ask questions, find answers, and see upcoming events.   

- [Blog](https://cloudblogs.microsoft.com/dynamics365/?s=Resource+Scheduling): On the blog, you’ll find ongoing release notes and posts from the product team.   

- The post [How to use Resource Scheduling’s Search Resource Availability API](https://cloudblogs.microsoft.com/dynamics365/it/2019/07/15/how-to-use-resource-schedulings-search-resource-availability-api/) appeared first on [Dynamics 365 Blog](https://cloudblogs.microsoft.com/dynamics365).   

### Sample code snippet

```csharp
void Main()<BR>  
{<BR>   
// Authentication<BR>   
String machineName = "aurorav?????";<BR>   
String orgName = "CITTest";   
String domain = $"{machineName}dom.extest.microsoft.com";<BR>   
String uri = $"http://{machineName}.{domain}/{orgName}/XRMServices/2011/Organization.svc";<BR>   
String username = "administrator";<BR>   
String password = "";<BR>

// Connect to organization<BR>
Microsoft.Pfe.Xrm.OrganizationServiceManager osm = new<BR>
Microsoft.Pfe.Xrm.OrganizationServiceManager(new Uri(@uri), username, password, domain);<BR>

searchResourceAvailabilityForRequirementGroup(osm);<BR>  
createRequirementGroupBookings(osm);<BR>  
}<BR>   

void searchResourceAvailabilityForRequirementGroup(OrganizationServiceManager osm)<BR> 
{<BR>
var req = new OrganizationRequest()<BR>
{<BR>
RequestName = "msdyn_SearchResourceAvailabilityForRequirementGroup"<BR>
};<BR>  

//Version<BR>  
req["Version"] = "1.0.0";<BR>
req["RequirementGroup"] = new EntityReference("msdyn_requirementgroup", Guid.Parse(""));<BR>

var response = osm.GetProxy().Execute(req);<BR>
}   
<BR>
void createRequirementGroupBookings(OrganizationServiceManager osm)<BR>
{<BR>
var req = new OrganizationRequest()<BR>
{<BR>   
RequestName = "msdyn_createRequirementGroupBookings"<BR>
};   
<BR> 
//Version<BR>
req["Version"] = "1.0.0";<BR>
req["RequirementGroup"] = new EntityReference<BR>("msdyn_requirementgroup",<BR> 
Guid.Parse("d723dd8f-f4f4-e911-a81d-000d3af9eba2"));<BR>
req["Start"] = DateTime.Today.AddDays(1);<BR>
req["Duration"] = 60;<BR>
EntityCollection resourceAssignment = new EntityCollection();<BR>
var entity = new Entity();<BR>
entity["RequirementId"] = "";<BR>
entity["ResourceId"] = "";<BR>
entity["BookingStatusId"] = "";<BR>
resourceAssignment.Add(entity);<BR> 
req["ResourceAssignment"] = resourceAssignment;<BR>   

var response = osm.GetProxy().Execute(req);<BR> 
}<BR>  
```

## How to migrate from legacy API to URS API 

Migration can be done for legacy Search and Book API to URS API. Use the following required input and output fields to map API: 

### Input Mapping data for Search API 

|Legacy Input |URS Input |Description| 
|-------------|----------|-----------|
|ServiceId    |Requirement group  |Service/Requirement group GUID|
|SearchWindowStart|Start date  |Start date for the appointment search |
|SearchWindowEnd   |End date |End date for the appointment search |
|Duration  |Duration  |Appointment duration |
|No of results  |Page size |Total no of proposals / No. of appointment in a page |
|Sites  |OrganizationUnits  |Site/OU GUID |
|RequiredResource  |Preferred Resources|Resources which customer prefers to schedule. |
|Constraints |Constraints |Customer entity(ufx) |
|RecurrenceDuration     |                     |In case of recurrence appointment search, duration for appointment |
|RecurrenceTimeZoneCode |                     |Time Zone for a recurring request.        |
|SearchDirection        |                     |Forward or backward search for slots based on dates given. |
|AnchorOffSet           |                     |Offset in hours from midnight             |
|UserTimeZoneCode       |                     |Time zone for user which is set           | 
|SearchRecurrenceRule   |                     |Frequency and interval and count etc      | 
|                       |Resource Types       |Type of resource                          |
|                       |Restricted Resources |Restricted for scheduling the appointment |

###  Output Mapping for Search API 

|Legacy Output |URS Output |
|--------------|-----------|
|Appointment proposals |ProposalsResourceAssignmentSet |
|Traceinfo | |
|ExtenstionDataObject | | 
|   |Time Slots|
|   |Requirements(contraintbag) |
|   |Paginginfos |

## How to migrate from legacy API to URS API Example Scenarios 

This section adds more details on API mapping from legacy to the new URS API explained with the example. Below are scenario-based explanations and elaboration of new API adaption.  

## Scenario 1: Legacy setup screen shot for reference.  

![Legacy setup screen shot for reference](media\ur-scheduling-16-new.png)

1. Create one Site (Site1) and one User (User1) and one equipment (facility/ equipment) (Eq1) with a site as Site1. 

2. Create the business closure and work hours for User(8.00AM-6.00PM) and equipment(8.00AM-6.00PM). 

3. Create a new service (Service1)with add required resources as "Choose 2” from User1, Eq1. Save and close the service. 

![Service Activity](media\ur-scheduling-17-new.png)

4. Go to homepage -> Service Activity -> select the service and click on Schedule -> Now click on find available slots. 

5. Verify 2 resources are returned for each proposal as per the set criteria.  

### URS API Code for the above scenario. 

```csharp
void searchRequirementgroup(Microsoft.Pfe.Xrm.OrganizationServiceManager osm)<BR>
{ <BR>
var req = new Microsoft.Xrm.Sdk.OrganizationRequest() <BR>
{ <BR>
RequestName = "msdyn_SearchResourceAvailabilityForRequirementGroup"<BR>
};<BR>

  req["Version"] = "1.0.0"; <BR>
  Entity requirementSpecification = new Entity();

  //Setting from date 
  requirementSpecification.Attributes.Add("msdyn_fromdate", DateTime.Parse("2019-12-  
  26T18:30:00.000Z"));

  //Setting to date 
  requirementSpecification.Attributes.Add("msdyn_todate", DateTime.Parse("2019-12- 
  27T18:29:00.000Z"));

  //Requirement group GUID 
  req["RequirementSpecification"] = requirementSpecification; 
  req["RequirementGroup"] = new   
  Microsoft.Xrm.Sdk.EntityReference("msdyn_requirementgroup", Guid.Parse("XXXXXXXX"));

  //Executing the request and getting response<BR>
  var response = osm.GetProxy().Execute(req);<BR> 
  response.ToString();<BR> 
  response.Dump();<BR>
} 	 
```

## Scenario 2: Legacy setup screen shot for reference 

![Legacy setup screen shot for reference](media\ur-scheduling-18-new.png)

1. Create the following: 
- two Site (Micr0s0ftSite1, Site2)
- two Users (User1 and User2 (Site2))
- two equipment(facility/equipment) (Eq1, Eq2),  where Eq1 belongs to Site1 and Eq2 belongs to Site2.
 
2. Create the business closure and work hours for User(8.00AM-6.00PM) and equipment(8.00AM-6.00PM). 

3. Create a new service with status "reserved" and required resources as "Choose 2” from “same site “ from User1, User2, Eq1, Eq2. Save and close the service. 

![Service Activity](media\ur-scheduling-19-new.png)

4. Go to the homepage -> Service Activity -> Schedule -> select service created above -> and select the site as Site1 and click Search for a specific start and end time. 

5. Verify that search results are return as per the site selected in the search criteria. 

### New URS API Code for the above scenario

```csharp
void searchRequirementgroup(Microsoft.Pfe.Xrm.OrganizationServiceManager osm)<BR>
{<BR>
  var req = new Microsoft.Xrm.Sdk.OrganizationRequest()<BR>
  {<BR>
  RequestName = "msdyn_SearchResourceAvailabilityForRequirementGroup"<BR>
  };<BR>
req["Version"] = "1.0.0";<BR> 
Entity requirementSpecification = new Entity();<BR>

//Setting from date<BR>
requirementSpecification.Attributes.Add("msdyn_fromdate", DateTime.Parse("2019-12-26T18:30:00.000Z"));<BR>

//Setting to date<BR>
requirementSpecification.Attributes.Add("msdyn_todate", DateTime.Parse("2019-12-27T18:29:00.000Z")); <BR>

//Setting up the Site as filter criteria for search.<BR>	      
requirementSpecification.Attributes.Add("msdyn_organizationalunit",Guid.Parse("XXXXXXXXXXXX")); <BR>

req["RequirementSpecification"] = requirementSpecification;<BR>

//Requirement group GUID <BR>     
req["RequirementGroup"] = new EntityReference("msdyn_requirementgroup", Guid.Parse("XXXXXX"));<BR>

var response = osm.GetProxy().Execute(req);<BR>
response.ToString();<BR>
response.Dump();<BR>
<BR>
}<BR>
```

## Scenario 3: Legacy setup screen shot for reference

![Legacy setup screen shot for reference](media\ur-scheduling-20-new.png)

1. Create two Site(Site1, Site2) and then create 3 equipment (eq1, eq2, eq3) 

2. Create the business closure and work hours for all equipment(3.00PM-6.00PM). 

3. Create a new service (Service1)Choose 1 from (Random) eq1, eq2, eq3 

![Service Activity](media\ur-scheduling-21-new.png)

4. On the Schedule Service Activity dialog (scheduling dialog) search for proposals for Service1 by adding a required resource as "eq1" for a specific date range. 

5. Verify the proposals are returned are in the working hours of the equipment for that date. 

### New URS API Code for the above scenario

```csharp
void searchRequirementgroup(Microsoft.Pfe.Xrm.OrganizationServiceManager osm)<BR>
{<BR>
var req = new Microsoft.Xrm.Sdk.OrganizationRequest()<BR> 
{<BR>
RequestName = "msdyn_SearchResourceAvailabilityForRequirementGroup"<BR>
};<BR>
req["Version"] = "1.0.0";<BR> 
Entity requirementSpecification = new Entity();<BR>

//Setting start date<BR>          
requirementSpecification.Attributes.Add("msdyn_fromdate", DateTime.Parse("2019-12-26T18:30:00.000Z"));<BR>
//Setting end date<BR>
requirementSpecification.Attributes.Add("msdyn_todate", DateTime.Parse("2019-12-27T18:29:00.000Z"));<BR>

//Setting the eq1 as required resource<BR>	 	 requirementSpecification.Attributes.Add("msdyn_resourcerequirementid",Guid.Parse("XXXXXX")); <BR>
req["RequirementSpecification"] = requirementSpecification; <BR>

//Setting the requirement group GUID<BR>
req["RequirementGroup"] = new EntityReference("msdyn_requirementgroup", Guid.Parse("XXXXX"));<BR>

//Executing the request and getting response.<BR> 
var response = osm.GetProxy().Execute(req); <BR>
response.ToString(); <BR>
response.Dump(); <BR>
} <BR>
```

## See Also

[Service Scheduling Guide](basics-service-service-scheduling.md)<br />
[Frequently asked questions for Service Scheduling](service-scheduling-faq.md)<br />