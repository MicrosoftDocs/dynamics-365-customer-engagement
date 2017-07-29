---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_fieldservicesetting EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 211f4dc8-6ccf-47bd-8255-7fff5f8fd5a9
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_fieldservicesetting entitytype."
---
# msdyn_fieldservicesetting EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_fieldservicesetting.md](./descriptions/msdyn_fieldservicesetting.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_fieldservicesettings </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Field Service Setting</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_fieldservicesettingid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_fieldservicesetting entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_advancedsettings|Edm.String|**Display Name**: Advanced Settings<br />**Description**: For internal use only.<br />|
|msdyn_agreementprefix|Edm.String|**Display Name**: Agreement Prefix<br />|
|msdyn_agreementstartingnumber|Edm.Int32|**Display Name**: Agreement Starting Number<br />|
|msdyn_autoallocateestimatedproducts|Edm.Boolean|**Display Name**: Auto Allocate Estimated Products<br />**Description**: If enabled then Allocated will be automatically set when entering a Work order Product with a Line Status of Estimate.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_autogeneratewoforagreementbooking|Edm.Boolean|**Display Name**: Auto Generate WO for Agreement Booking<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_autogeocodeaddresses|Edm.Boolean|**Display Name**: Auto Geo Code Addresses<br />**Description**: If set then the system will automatically geo code addresses when the address has been updated and the record is saved<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_bookingalerttemplate|Edm.String|**Display Name**: Booking Alert Template (Deprecated)<br />|
|msdyn_cancelcurrentslotswhenmoving|Edm.Boolean|**Display Name**: Cancel Current Slots When Moving (Deprecated)<br />**Description**: Select whether, when moving open slots to the next day, to leave the old slots and change their status to "Cancel."<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_customgpsdata|Edm.Boolean|**Display Name**: Custom GPS Data (Deprecated)<br />**Description**: If enabled system will use custom entity for its source of Geo Locations for resources to be displayed on map view<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_customgpslatitudefield|Edm.String|**Display Name**: Custom GPS Latitude field (Deprecated)<br />**Description**: Shows the logical name of the latitude field to be used for geolocations.<br />|
|msdyn_customgpslocationentity|Edm.String|**Display Name**: Custom GPS Location entity (Deprecated)<br />**Description**: Shows the logical name of custom entity to be used for geolocations.<br />|
|msdyn_customgpslongitudefield|Edm.String|**Display Name**: Custom GPS Longitude field (Deprecated)<br />**Description**: Shows the logical name of the longitude field to be used for geolocations.<br />|
|msdyn_customgpsresourcefield|Edm.String|**Display Name**: Custom GPS Resource field (Deprecated)<br />**Description**: Shows the logical name of the resource field to be used for geolocations.<br />|
|msdyn_customgpstimestampfield|Edm.String|**Display Name**: Custom GPS Timestamp field (Deprecated)<br />**Description**: Shows the logical name of the timestamp field to be used for geolocations.<br />|
|msdyn_databaseversion|Edm.Int32|**Display Name**: Database Version<br />**Description**: For Internal Use<br />|
|msdyn_deactivatebookingwhencanceled|Edm.Boolean|**Display Name**: Deactivate Booking When Canceled<br />**Description**: Select whether the system should deactivate the resource booking when the system status is changed to "Canceled."<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_deactivatebookingwhencompleted|Edm.Boolean|**Display Name**: Deactivate Booking When Completed<br />**Description**: Select whether the system should deactivate the resource booking when the system status is changed to "Completed."<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_deactivateworkorderwhencanceled|Edm.Boolean|**Display Name**: Deactivate Work Order When Canceled<br />**Description**: Select whether the system should deactivate the work order when the system status is changed to "Closed - Canceled."<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_deactivateworkorderwhenposted|Edm.Boolean|**Display Name**: Deactivate Work Order When Posted<br />**Description**: Select whether the system should deactivate the work order when the system status is changed to "Closed - Posted."<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_defaultbookingduration|Edm.Int32|**Display Name**: Default Booking Duration (Deprecated)<br />|
|msdyn_defaultradiusunit|Edm.Boolean|**Display Name**: Default Radius Unit (Deprecated)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>mi</td></tr><tr><td>0</td><td>km</td></tr><tbody></table>|
|msdyn_defaultradiusvalue|Edm.Int32|**Display Name**: Default Radius Value (Deprecated)<br />|
|msdyn_defaultworkordercompletedstatus|Edm.Int32|**Display Name**: Default Work Order Completed Status<br />**Description**: Select whether the default work order completed status is either "Completed" or "Posted."<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Open - Unscheduled</td></tr><tr><td>690970001</td><td>Open - Scheduled</td></tr><tr><td>690970002</td><td>Open - In Progress</td></tr><tr><td>690970003</td><td>Open - Completed</td></tr><tr><td>690970004</td><td>Closed - Posted</td></tr><tr><td>690970005</td><td>Closed - Canceled</td></tr><tbody></table>|
|msdyn_enablelegacyscheduleassistant|Edm.Boolean|**Display Name**: Enable Legacy Schedule Assistant<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_entitynumberlength|Edm.Int32|**Display Name**: Entity Number Length<br />|
|msdyn_fieldservicesettingid|Edm.Guid|**Display Name**: Field Service Setting<br />**Description**: Shows the entity instances.<br />|
|msdyn_generateagreementinvoicesxdaysinadvance|Edm.Int32|**Display Name**: Generate Agreement Invoices X Days In Advance<br />|
|msdyn_generateagreementwoxdaysinadvance|Edm.Int32|**Display Name**: Generate Agreement WO X Days In Advance<br />**Description**: Specify default how many days in advance of the Agreement Booking Date the system should automatically generate a Work Order<br />|
|msdyn_generatebookingdatesxmonthsinadvance|Edm.Int32|**Display Name**: Generate Booking Dates X Months In Advance<br />|
|msdyn_generateinvoicedatesxmonthsinadvance|Edm.Int32|**Display Name**: Generate Invoice Dates X Months In Advance<br />|
|msdyn_gpslocationexpiresafterxminutes|Edm.Int32|**Display Name**: GPS Location Expires After X Minutes (Deprecated)<br />|
|msdyn_inventoryadjustmentprefix|Edm.String|**Display Name**: Inventory Adjustment Prefix<br />**Description**: Shows the prefix to be added to the inventory adjustment numbers.<br />|
|msdyn_inventoryadjustmentstartingnumber|Edm.Int32|**Display Name**: Inventory Adjustment Starting Number<br />**Description**: Shows the number to be used as the starting number for inventory adjustments.<br />|
|msdyn_inventorytransferprefix|Edm.String|**Display Name**: Inventory Transfer Prefix<br />**Description**: Shows the prefix to be added to the inventory transfer numbers.<br />|
|msdyn_inventorytransferstartingnumber|Edm.Int32|**Display Name**: Inventory Transfer Starting Number<br />**Description**: Shows the number to be used as the starting number for inventory transfers.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Enter the name of the custom entity.<br />|
|msdyn_notificationtimeout|Edm.Int32|**Display Name**: Notification Timeout (In sec) (Deprecated)<br />|
|msdyn_postponenumbercleanupuntil|Edm.DateTimeOffset|**Display Name**: Postpone Number Cleanup Until<br />**Description**: Shows the date when cleanup of unique numbers will occur.<br />|
|msdyn_productcostorder|Edm.Int32|**Display Name**: Product Cost Order<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Standard/Current</td></tr><tr><td>690970001</td><td>Current/Standard</td></tr><tbody></table>|
|msdyn_purchaseorderapprovalrequired|Edm.Boolean|**Display Name**: Purchase Order Approval Required<br />**Description**: Enable if a Purchase Order requires approval in order for the status to be changed to Submitted<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_purchaseorderprefix|Edm.String|**Display Name**: Purchase Order Prefix<br />**Description**: Shows the prefix to be added to the purchase order numbers.<br />|
|msdyn_purchaseorderstartingnumber|Edm.Int32|**Display Name**: Purchase Order Starting Number<br />**Description**: Shows the number to be used as starting number for the automatically generated purchase order number.<br />|
|msdyn_resourcessynchronizationtimeout|Edm.Int32|**Display Name**: Resources Synchronization Timeout (Deprecated)<br />|
|msdyn_rmaprefix|Edm.String|**Display Name**: RMA Prefix<br />|
|msdyn_rmastartingnumber|Edm.Int32|**Display Name**: RMA Starting Number<br />**Description**: Shows the number to be used as the starting number for the automatically generation RMA number.<br />|
|msdyn_rtvprefix|Edm.String|**Display Name**: RTV Prefix<br />|
|msdyn_rtvstartingnumber|Edm.Int32|**Display Name**: RTV Starting Number<br />**Description**: Shows the number to be used as the starting number for the automatically generated RTV number.<br />|
|msdyn_saautofilterserviceterritory|Edm.Boolean|**Display Name**: Auto Filter Service Territory (Deprecated)<br />**Description**: Select whether the schedule assistant should automatically filter the results based on the territory set on the work order.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_schedulerbusinessunitdetailsview|Edm.String|**Display Name**: Scheduler Business Unit Details View (Deprecated)<br />|
|msdyn_schedulerbusinessunittooltipview|Edm.String|**Display Name**: Scheduler Business Unit Tooltip View (Deprecated)<br />|
|msdyn_schedulercoredetailsview|Edm.String|**Display Name**: Scheduler Core Details View (Deprecated)<br />|
|msdyn_schedulercoreslottexttemplate|Edm.String|**Display Name**: Scheduler Core Slot Text Template (Deprecated)<br />|
|msdyn_schedulercoretooltipview|Edm.String|**Display Name**: Scheduler Core Tooltip View (Deprecated)<br />|
|msdyn_schedulerfieldservicedetailsview|Edm.String|**Display Name**: Scheduler Field Service Details View (Deprecated)<br />|
|msdyn_schedulerfieldserviceslottexttemplate|Edm.String|**Display Name**: Scheduler Field Service Slot Text Template (Deprecated)<br />|
|msdyn_schedulerfieldservicetooltipview|Edm.String|**Display Name**: Scheduler Field Service Tooltip View (Deprecated)<br />|
|msdyn_schedulerresourcedetailsview|Edm.String|**Display Name**: Scheduler Resource Details View (Deprecated)<br />|
|msdyn_schedulerresourcetooltipview|Edm.String|**Display Name**: Scheduler Resource Tooltip View (Deprecated)<br />|
|msdyn_schedulerunscheduledview|Edm.String|**Display Name**: Scheduler Unscheduled View (Deprecated)<br />|
|msdyn_sdkapimapkey|Edm.String|**Display Name**: Bing API Key (Deprecated)<br />**Description**: Api key for map<br />|
|msdyn_traveltimerescheduling|Edm.Boolean|**Display Name**: Travel Time Rescheduling (Deprecated)<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_undefinedbookinglocation|Edm.Int32|**Display Name**: Undefined Booking Location (Deprecated)<br />**Description**: Location for schedules where geo code info has not been defined<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Previous Known Location</td></tr><tr><td>690970001</td><td>Ignore Location</td></tr><tbody></table>|
|msdyn_unscheduledwotooltipsviewid|Edm.String|**Display Name**: Unscheduled WO Tooltips View Id (Deprecated)<br />|
|msdyn_useofproductsoutofstock|Edm.Int32|**Display Name**: Use of Products Out of Stock<br />**Description**: Specify how the system should react when trying to use products that are out of stock.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Confirm</td></tr><tr><td>690970001</td><td>Restrict</td></tr><tbody></table>|
|msdyn_workorderinvoicecreation|Edm.Int32|**Display Name**: Work Order Invoice Creation<br />**Description**: Specify whether the system should automatically generate an invoice for work orders.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970001</td><td>On Work Order Posted</td></tr><tr><td>690970000</td><td>Never</td></tr><tbody></table>|
|msdyn_workorderprefix|Edm.String|**Display Name**: Work Order Prefix<br />|
|msdyn_workorderstartingnumber|Edm.Int32|**Display Name**: Work Order Starting Number<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Field Service Setting<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Shows the reason for the status of the field service setting.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_msdyn_breakpaytype_value|msdyn_breakpaytype<br />|Default Pay Type to be used for Break hours|
|_msdyn_businessclosurepaytype_value|msdyn_businessclosurepaytype<br />|Default Pay Type to be used for business closure work hours|
|_msdyn_defaultcanceledbookingstatus_value|msdyn_defaultcanceledbookingstatus<br />||
|_msdyn_defaultscheduledbookingstatus_value|msdyn_defaultscheduledbookingstatus<br />||
|_msdyn_defaultwarehouse_value|msdyn_defaultwarehouse<br />|Shows the warehouse associated with the field service setting.|
|_msdyn_overtimepaytype_value|msdyn_overtimepaytype<br />|Default Pay Type to be used for overtime work hours|
|_msdyn_travelchargeitemid_value|msdyn_travelchargeitemid<br />|Product/Service to be used by the system for Travel Charges on Work Orders|
|_msdyn_travelpaytype_value|msdyn_travelpaytype<br />|Default Pay Type to be used for Travel hours|
|_msdyn_workpaytype_value|msdyn_workpaytype<br />|Default Pay Type to be used for regular work hours|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_fieldservicesetting_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_fieldservicesetting_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_fieldservicesetting_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_fieldservicesetting_modifiedonbehalfby|
|msdyn_breakpaytype|[msdyn_resourcepaytype EntityType](msdyn_resourcepaytype.md)|msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType|
|msdyn_businessclosurepaytype|[msdyn_resourcepaytype EntityType](msdyn_resourcepaytype.md)|msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType|
|msdyn_defaultcanceledbookingstatus|[bookingstatus EntityType](bookingstatus.md)|msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus|
|msdyn_defaultscheduledbookingstatus|[bookingstatus EntityType](bookingstatus.md)|msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus|
|msdyn_defaultwarehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse|
|msdyn_overtimepaytype|[msdyn_resourcepaytype EntityType](msdyn_resourcepaytype.md)|msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType|
|msdyn_travelchargeitemid|[product EntityType](product.md)|msdyn_product_msdyn_fieldservicesetting|
|msdyn_travelpaytype|[msdyn_resourcepaytype EntityType](msdyn_resourcepaytype.md)|msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType|
|msdyn_workpaytype|[msdyn_resourcepaytype EntityType](msdyn_resourcepaytype.md)|msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_fieldservicesetting|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_fieldservicesetting|
|owningteam|[team EntityType](team.md)|team_msdyn_fieldservicesetting|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_fieldservicesetting|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_fieldservicesetting_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_fieldservicesetting|  
|msdyn_fieldservicesetting_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_fieldservicesetting_adx_alertsubscription|  
|msdyn_fieldservicesetting_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_fieldservicesetting_adx_inviteredemption|  
|msdyn_fieldservicesetting_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_fieldservicesetting_adx_portalcomment|  
|msdyn_fieldservicesetting_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_fieldservicesetting|  
|msdyn_fieldservicesetting_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_fieldservicesetting_appointment|  
|msdyn_fieldservicesetting_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_fieldservicesetting|  
|msdyn_fieldservicesetting_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_fieldservicesetting|  
|msdyn_fieldservicesetting_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_fieldservicesetting_email|  
|msdyn_fieldservicesetting_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_fieldservicesetting_fax|  
|msdyn_fieldservicesetting_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_fieldservicesetting_letter|  
|msdyn_fieldservicesetting_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_fieldservicesetting_msdyn_approval|  
|msdyn_fieldservicesetting_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_fieldservicesetting_msdyn_bookingalert|  
|msdyn_fieldservicesetting_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_fieldservicesetting_msdyn_surveyinvite|  
|msdyn_fieldservicesetting_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_fieldservicesetting_phonecall|  
|msdyn_fieldservicesetting_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_fieldservicesetting_recurringappointmentmaster|  
|msdyn_fieldservicesetting_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_fieldservicesetting_serviceappointment|  
|msdyn_fieldservicesetting_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_fieldservicesetting_socialactivity|  
|msdyn_fieldservicesetting_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_fieldservicesetting|  
|msdyn_fieldservicesetting_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_fieldservicesetting_task|  

## Operations
The following operations can be used with the msdyn_fieldservicesetting entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_fieldservicesetting entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_fieldservicesetting.md](./remarks/msdyn_fieldservicesetting.md)]

### See also  
 [Use the Microsoft Dynamics CRM Web API](https://msdn.microsoft.com/library/mt593051.aspx)<br />
 [Web API EntityType Reference](../entitytypereference.md)<br />
 [Web API Action Reference](../actionreference.md)<br />
 [Web API Function Reference](../functionreference.md)<br />
 [Web API Query Function Reference](../queryfunctionreference.md)<br />
 [Web API EnumType Reference](../enumtypereference.md)<br />
 [Web API ComplexType Reference](../complextypereference.md)<br />
 [Web API Metadata EntityType Reference](../entitytypereference.md)<br />
 [Web API Solutions Reference](../solutionreference.md)<br />