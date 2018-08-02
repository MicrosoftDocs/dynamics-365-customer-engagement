---
title: "Enable and use Activity Logging (Dynamics 365 Customer Engagement)| MicrosoftDocs"
ms.custom: ""
description: Learn how to enable auditing to be used for reports in the Office 365 Security Compliance Center.
ms.date: 06/13/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 817fb922-355a-4d5c-9d93-a320be31c276
caps.latest.revision: 1
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Enable and use Activity Logging 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

> [!IMPORTANT]
> - This feature currently has limited availability.
> - We expect some changes to this feature.

Protecting data, preserving privacy, and complying with regulations such as the [General Data Protection Regulation](https://www.microsoft.com/en-us/TrustCenter/Privacy/gdpr/default.aspx) are certainly some of the highest priorities for your business. It's critical that you audit the entirety of data processing actions taking place to be able to analyze for possible security breaches. This information from Activity Logging can be used when you perform a Data Protection Impact Assessment (DPIA) addressing the use of Office and Dynamics 365.  

This topic covers how you can set [!INCLUDE [pn-ms-dyn-365](../includes/pn-ms-dyn-365.md)] to audit a broad range of data processing activities and use the [Office 365 Security and Compliance Center](https://support.office.com/en-us/article/go-to-the-office-365-security-compliance-center-7e696a40-b86b-4a20-afcc-559218b7b1b8?ui=en-US&rs=en-US&ad=US) to review the data in activity reports.

## Requirements
- An Office 365 Enterprise [E3](https://products.office.com/business/office-365-enterprise-e3-business-software) or [E5](https://products.office.com/business/office-365-enterprise-e5-business-software) subscription is required to do Activity Logging.
- For version 8.x, version 8.2.2.1310 or later is required.
- Available for production and not Sandbox instances.

## How this differs from past audit logging
Audit logging as described in [Audit data and user activity for security and compliance](audit-data-user-activity.md) covers enabling and viewing logging for specific entities and attributes which you select. What is logged is largely based on the context of the activity. Open a record and activities such as who created the record, what values were entered and changed, who updated it, etc, are logged for that particular record.

Activity Logging has two significant differences with prior [!INCLUDE [pn-ms-dyn-365](../includes/pn-ms-dyn-365.md)] auditing:

1. You can log user and admin activities across Office and Dynamics 365 apps.

   ![Activities across apps](media/activities-across-apps.png "Activities across apps")

2. Auditing occurs at the SDK layer of Dynamics 365 which means much more data is logged than just activities. 

## What events are audited
Logging takes place at the SDK layer which means a single action can trigger multiple events that are logged. The following are a sample of admin and user events you can audit.

### Admin-related events

|Event  |Description  |
|---------|---------|
|Publishing customizations  |An admin publishes a new customization which overrides a change done by the previous one. The action requires auditing for analysis.    |
|Attribute deletes     |Admin accidentally deletes an attribute. This action also deletes the data. |
|Team, user management     |Who was added, who was deleted, what access rights a user/team had is important for analyzing impact.|
|Configure instance     |Adding solutions to an instance.|
|Backup and restore     |Backup and restore actions at the tenant.|
|Manage applications     |New instance added, existing instance deleted, trials converted to paid, etc.|

### User and support-related events 

|Event  |Description  |
|---------|---------|
|Create, read, update, delete (CRUD)     |Logging all CRUD activities essential for understanding the impact of a problem and being compliant with data protection impact assessments (DPIA). |
|Multiple record view     |Users of Dynamics view information in bulk, like grid views, Advanced Find search, etc. Critical customer content information is part of these views.|
|Export to Excel     |Exporting data to Excel moves the data outside of the secure environment and is vulnerable to threats.|
|SDK calls via surround or custom apps     |Actions taken via the core platform or surround apps calling into the SDK to perform an action needs to be logged.|
|All support CRUD activities     |Microsoft support engineer activities on customer environment.|
|Admin activities     |Admin activities on customer tenant.|
|Backend commands     |Microsoft support engineer activities on customer tenant and environment.|
|Report Viewed  |Logging when a report is viewed. Critical customer content information might be displayed on the report.  |
|Report Viewer Export  |Exporting a report to different formats moves the data outside of the secure environment and is vulnerable to threats.  |
|Report Viewer Render Image  |Logging multimedia assets that are shown when a report is displayed. They might contain critical customer information.  |

### Microsoft Social Engagement logging   

The following Microsoft Social Engagement (MSE) entities and actions are logged.

|MSE entity  |MSE pages/panels/controls logged  |
|---------|---------|
|Search Topic Category      |Create, Rename, Delete          |
|Search Topic      |Create, Update, Delete          |
|Custom Source      |Create, Update, Delete           |
|Blocked Keyword      |Add, Delete          |
|Blocked Domain      |Add, Delete          |
|Stream      |Create, Update, Delete         |
|Post (acquired)   |Internal & External Actions   |
|Post (published)   |Send   |
|Author   |Add (GDPR), Delete (GDPR), Delete   |
|Activity Map   |Create, Update, Delete   |
|Alert   |Create, Update, Delete   |
|Preference   |Update   |
|Social Profile   |Create, Update, Reauthenticate, Delete   |
|User   |Edit Role, E-mail   |
|Azure Event Hubs   |Create, Update, Delete   |
|Dynamics 365   |Create, Update, Refresh, Delete   |
|Allowed Domain   |Add, Delete   |
|Automation Rule   |Create, Update, Delete   |
|AR Notification   |Enable, Disable   |
|Tag   |Add, Update, Delete   |
|Label   |Add, Update Delete    |
|Search Language   |Add, Delete   |
|Adaptive Sentiment   |Enable, Disable, Reset   |
|Other Global Settings   |Update   |

## Base schema
Schemas define which Dynamics 365 fields are sent to the Office 365 Security and Compliance Center.  Some fields are common to all applications that send audit data to Office 365, while others are specific to Dynamics 365. The Base schema contains the common fields. 

|Field name  |Type  |Mandatory  |Description  |
|---------|---------|---------|---------|
|Date     |Edm.Date|No         |Date and time of when the log was generated in UTC          |
|IP address     |Edm.String         |No         |IP address of the user or corporate gateway          |
|Id     |Edm.Guid         |No         |Unique GUID for every row logged          |
|Result Status     |Edm.String         |No         |Status of the row logged. Success in most cases          |
|Organization Id     |Edm.Guid         |Yes        |Unique identifier of the organization from which the log was generated. You can find this ID under Dynamics Developer Resources.          |
|ClientIP     |Edm.String         |No         |IP Address of the user or corporate gateway          |
|CorrelationId     |Edm.Guid         |No         |A unique value used to associate related rows (e.g., when a large row is split)          |
|CreationTime     |Edm.Date         |No         |Date and time of when the log was generated in UTC          |
|Operation     |Edm.Date         |No         |Name of the message called in Dynamics 365 SDK          |
|UserKey     |Edm.String         |No         |Unique Identifier of the User in AAD. AKA User PUID          |
|UserType     |Self.UserType         |No         |The Office 365 audit type (Admin, Regular, System)          |
|User     |Edm.String        |No         |UPN of the user          |

## Dynamics 365 schema
The Dynamics 365 schema contains fields specific to Dynamics 365 and partner teams. 

|Field name  |Type  |Mandatory  |Description  |
|---------|---------|---------|---------|
|User Id     |Edm.String         |No         |Unique identifier of the user GUID in the Dynamics 365 organization          |
|Crm Organization Unique Name     |Edm.String         |No         |Unique name of the Dynamics 365 organization          |
|Instance Url     |Edm.String         |No         |URL to the instance          |
|Item Url     |Edm.String         |No         |URL to the record emitting the log          |
|Item Type     |Edm.String         |No         |Name of the entity          |
|Message     |Edm.String         |No         |Name of the message called in Dynamics 365 SDK          |
|User Agent     |Edm.String         |No         |Unique identifier of the user GUID in the Dynamics 365 organization          |
|EntityId     |Edm.Guid        |No         |Unique identifier of the entity          |
|EntityName     |Edm.String         |No         |Name of the entity in the Dynamics 365 organization          |
|Fields     |Edm.String          |No         |JSON of Key Value pair reflecting the values that were created or updated         |
|Id     |Edm.String          |No         |Entity name in Dynamics 365          |
|Query     |Edm.String         |No         |The Filter query parameters used while executing the FetchXML          |
|QueryResults     |Edm.String         |No         |One or multiple unique records returned by the Retrieve and Retrieve Multiple SDK message call          |
|ServiceContextId     |Edm.Guid         |No         |The unique id associated with service context          |
|ServiceContextIdType     |Edm.String         |No         |Application defined token to define context use          |
|ServiceName     |Edm.String         |No         |Name of the Service generating the log          |
|SystemUserId     |Edm.Guid         |No         |Unique identifier of the user GUID in the Dynamics 365 organization          |
|UserAgent     |Edm.Guid          |No        |Browser used to execute the request          |
|UserId     |Edm.Guid          |No         |The unique id of the Dynamics system user associated with this activity          |
|UserUpn     |Edm.String         |No         |User principal name of the user associated with this activity          |

## Enable auditing in Dynamics 365

1. In Dynamics 365 (online), choose **Settings** > **Administration** > **System Settings** > **Auditing tab**.
2. Under **Audit Settings**, enable the following check boxes:
   - **Start Auditing**
   - **Audit user access**
   - **Start Read Auditing** (Note: this only appears if you enable **Start Auditing**.)
3. Under **Enable Auditing in the following areas**, enable the check boxes for the areas you want to audit and then choose **OK**.
   
   ![System Settings Auditing](media/system-settings-auditing.png "System Settings Auditing")
4. Go to **Settings** > **Customizations** > **Customize the System**
5. Under **Components**, expand **Entities** and select an entity to audit, such as **Account**.
6. Scroll down and under **Data Services** enable **Auditing**.
7. Under **Auditing**, enable the following check boxes:
   - **Single record auditing. Log a record when opened.**
   - **Multiple record auditing. Log all records displayed on an opened page.**

   ![Retrieve Auditing](media/retrieve-auditing.png "Retrieve Auditing")
8. Choose **Save**.
9. Choose **Publish** to publish the customization.
10. Repeat steps 5 - 9 for other entities you want to audit.
11. Turn on audit logging in Office 365. See [Turn Office 365 audit log search on or off](https://support.office.com/article/turn-office-365-audit-log-search-on-or-off-e893b19a-660c-41f2-9074-d3631c95a014).


## Review your audit data using reports in Office 365 Security and Compliance Center

You can review your audit data in the Office 365 Security and Compliance Center. See [Search the audit log for user and admin activity in Office 365](https://support.office.com/article/search-the-audit-log-for-user-and-admin-activity-in-office-365-57ca5138-0ae0-4d34-bd40-240441ef2fb6).

To use the preconfigured Dynamics 365 reports, go to https://protection.office.com > **Search & investigation** > **Audit log search** and select the **Dynamics 365 activities** tab.

![Dynamics 365 audit log reports](media/D365-audit-log-reports.png "Dynamics 365 audit log reports")

![Audit log search results](media/audit-log-search-results.png "Audit log search results")

The following are the preconfigured Dynamics 365 reports:

|  |  |   |
|---------|---------|---------|
|Accessed out-of-box entity     |Accessed custom entity |Accessed admin entity  |
|Performed bulk actions (such as delete and import)  |Accessed other entity type   |Accessed Dynamics 365 admin center  |
|Accessed internal management tool |Signed in or out  |Activated process or plug-in  |

## Create reports
You can create your own reports to review your audit data. See [Search the audit log in the Office 365 Security & Compliance Center](https://support.office.com/article/search-the-audit-log-in-the-office-365-security-compliance-center-0d4d0f35-390b-4518-800e-0c7ec95e946c).

## What's logged

For a list of what's logged with Activity Logging, see [Microsoft.Crm.Sdk.Messages Namespace](https://docs.microsoft.com/dotnet/api/microsoft.crm.sdk.messages?view=dynamics-general-ce-9).

We log all SDK messages except the following:

- WhoAmI
-	RetrieveFilteredForms
-	TriggerServiceEndpointCheck
-	QueryExpressionToFetchXml
-	FetchXmlToQueryExpression
-	FireNotificationEvent
-	RetrieveMetadataChanges
-	RetrieveEntityChanges
-	RetrieveProvisionedLanguagePackVersion
-	RetrieveInstalledLanguagePackVersion
-	RetrieveProvisionedLanguages
-	RetrieveAvailableLanguages
-	RetrieveDeprovisionedLanguages
-	RetrieveInstalledLanguagePacks
-	GetAllTimeZonesWithDisplayName
-	GetTimeZoneCodeByLocalizedName
-	IsReportingDataConnectorInstalled
-	LocalTimeFromUtcTime
-	IsBackOfficeInstalled
-	FormatAddress
-	IsSupportUserRole
-	IsComponentCustomizable
-	ConfigureReportingDataConnector
-	CheckClientCompatibility
-	RetrieveAttribute

## How we categorize read and readmultiple

We use the prefix to categorize.

|If the request starts with:  |We characterize as:  |
|---------|---------|
|RetrieveMultiple     |ReadMultiple  |
|ExportToExcel     |ReadMultiple |
|RollUp |ReadMultiple |
|RetrieveEntitiesForAggregateQuery |ReadMultiple | 
|RetrieveRecordWall  |ReadMultiple | 
|RetrievePersonalWall  |ReadMultiple | 
|ExecuteFetch  |ReadMultiple | 
|Retrieve      |Read  |
|Search     |Read |
|Get     |Read |
|Export     |Read |

## Example generated logs

The following are some examples of logs created with Activity Logging.

### Example 1 – Logs generated when user reads an Account record 

| **Schema Name** |                                                      **Value**                                                      |
|-----------------|---------------------------------------------------------------------------------------------------------------------|
|       ID        |                                        50e01c88-2e43-4005-8be8-9ceb172e2e90                                         |
|     UserKey     |                                                  10033XXXA49AXXXX                                                   |
|    ClientIP     |                                                   131.107.XXX.XX                                                    |
|    Operation    |                                                      Retrieve                                                       |
|      Date       |                                                3/2/2018 11:25:56 PM                                                 |
|    EntityId     |                                        0a0d8709-711e-e811-a952-000d3a732d76                                         |
|   EntityName    |                                                       Account                                                       |
|      Query      |                                                         N/A                                                         |
|  QueryResults   |                                                         N/A                                                         |
|     ItemURL     | https://orgname.onmicrosoft.com/main.aspx?etn=account&pagetype=entityrecord&id=0a0d8709-711e-e811-a952-000d3a732d76 |

### Example 2 – Logs generated when user sees Account records in a Grid (Export to Microsoft Excel logs are like this) 

|**Schema Name**  |**Value**  |
|---------|---------|
|ID     |ef83f463-b92f-455e-97a6-2060a47efe33          |
|UserKey     |10033XXXA49AXXXX           |
|ClientIP     |131.107.XXX.XX          |
|Operation     |RetrieveMultiple           |
|Date     |3/2/2018 11:25:56 PM          |
|EntityId     |N/A         |
|EntityName     |Account          |
|Query     |\<filter type="and">\<condition column="ownerid" operator="eq-userid" />\<condition column="statecode" operator="eq" value="0" />\</filter>         |
|QueryResults     |0a0d8709-711e-e811-a952-000d3a732d76, dc136b61-6c1e-e811-a952-000d3a732d76        |
|ItemURL     |N/A        |

### Example 3 – List of messages logged when user converts a lead to opportunity 

|**ID**  |**EntityID**  |**EntityName**  |**Operation**  |
|---------|---------|---------|---------|
|53c98033-cca4-4420-97e4-4c1b4f81e062      |23ad069e-4d22-e811-a953-000d3a732d76          |Contact         |Create         |
|5aca837c-a1f5-4801-b770-5c66183a58aa      |25ad069e-4d22-e811-a953-000d3a732d76          |Opportunity         |Create         |
|c9585748-fdbf-4ff7-970c-bb37f6aa2c36      |25ad069e-4d22-e811-a953-000d3a732d76          |Opportunity         |Update         |
|a0469f30-078b-419d-be61-b04c9a34121f      |1cad069e-4d22-e811-a953-000d3a732d76          |Lead         |Update         |
|0975bceb-07c7-4dc2-b621-5a7b245c36a4      |1cad069e-4d22-e811-a953-000d3a732d76          |Lead         |Update         |

## Additional considerations

When audit log search in the Office 365 Security and Compliance Center is turned on, user and admin activity from your organization is recorded in the audit log and retained for 90 days. However, your organization might not want to record and retain audit log data. Or you might be using a third-party security information and event management (SIEM) application to access your auditing data. In those cases, a global admin can turn off audit log search in Office 365.

## Known issues

- Office has a 3KB limit for each audit record. Therefore, in some cases a single record from Dynamics 365 needs to be split into multiple records in Office. The CorrelationId field can be used to retrieve the set of split records for a given source record. Operations that are likely to require splitting include RetrieveMultiple and ExportToExcel.
- Some operations need additional processing to retrieve all relevant data. For example, RetrieveMultiple and ExportToExcel are processed to extract the list of records that are retrieved or exported. However, not all relevant operations are yet processed. For example, ExportToWord is currently logged as single operation with no additional details about what was exported.
- In the Office 365 Security and Compliance Center (protection.office.com), the Activities drop-down has a section called Dynamics 365 activities, with nine activities listed. However, the audit logs currently only use the Accessed other entity type activity. Selecting any of the others alone will filter out all results. The simplest option for now is to click on the Dynamics 365 activities header, which will select all activities.
- In future releases, logging will disabled for operations that are determined to not be useful based on a review of the logs. For example, some operations result from automated system activity, not user activity.
- The new flags for enabling Read Auditing in the Organization settings and Entity Settings are not solution aware in version 8.2. Exporting a solution from an 8.2 instance to any other instance will not export these flags. 

### See also
 [Audit data and user activity for security and compliance](audit-data-user-activity.md)<br />
 [Search the audit log for user and admin activity in Office 365](https://support.office.com/article/search-the-audit-log-for-user-and-admin-activity-in-office-365-57ca5138-0ae0-4d34-bd40-240441ef2fb6)
 [Office 365 Management APIs overview](https://msdn.microsoft.com/office-365/office-365-managment-apis-overview)