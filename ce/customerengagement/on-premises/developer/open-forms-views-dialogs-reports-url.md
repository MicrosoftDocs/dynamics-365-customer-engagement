---
title: "Open forms, views, dialogs, and reports with a URL (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn more about URL addressable elements that enable you to include links to Dynamics 365 Customer Engagement (on-premises) forms, views, dialogs, and reports in other applications"
ms.custom: 
ms.reviewer: pehecke
ms.date: 02/03/2025
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: how-to
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - URL Addressable
  - entity forms, open with url
  - views, open with url
ms.assetid: a8015117-1aa1-40df-b418-e563424b7558
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer

---
# Open forms, views, dialogs, and reports with a URL

URL addressable elements enable you to include links to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] forms, views, dialogs, and reports in other applications. In this manner, you can easily extend other applications, reports, or websites so that users can view information and perform actions without switching applications.  

> [!NOTE]
> - URL addressable forms, views, dialogs, and reports cannot bypass [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] security. Only licensed [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] users, based on their security roles, can access the data and the records they see.  
>   -   Use `Xrm.Navigation.`[openForm](/powerapps/developer/model-driven-apps/clientapi/reference/Xrm-Navigation/openForm) when you open entity forms programmatically within the application by using web resources. Don't use `window.open`.  
>   -   Outside the application, where pages don't have access to the `Xrm.Navigation.`[openForm](/powerapps/developer/model-driven-apps/clientapi/reference/Xrm-Navigation/openForm) function, use `window.open` or a link to open a specific record or form for an entity.  

<a name="BKMK_URLAddressableFormsAndViews"></a>

## URL Addressable Forms and Views

 All entity forms and views are displayed in the main.aspx page. Query string parameters passed to this page control what will be displayed. For example:  

 To open a new account entity record form for on-premises [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]:  
 ```  
https://myorg.crm.dynamics.com/main.aspx?etn=account&pagetype=entityrecord  
 ```  

 To open an account entity record form for [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] where the id is {91330924-802A-4B0D-A900-34FD9D790829}:  
 ```  
https://myorg.crm.dynamics.com/main.aspx?etn=account&pagetype=entityrecord&id=%7B91330924-802A-4B0D-A900-34FD9D790829%7D  
 ```  

 To open the **Closed Opportunities** view for [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)]:  
 ```  
https://myorg.crm.dynamics.com/main.aspx?etn=opportunity&pagetype=entitylist&viewid=%7b00000000-0000-0000-00AA-000010003006%7d&viewtype=1039  
 ```  

 To open the **Active Contacts** view for [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] with no navigation bar or command bar  
 ```  
https://myorg.crm.dynamics.com/main.aspx?etn=contact&pagetype=entitylist&viewid={00000000-0000-0000-00AA-000010001004}&viewtype=1039&navbar=off&cmdbar=false  
 ```  

> [!NOTE]
>  Opening entity forms in a dialog window by using [showModalDialog](/previous-versions/ms536759(v=vs.85)) or [showModelessDialog](https://msdn.microsoft.com/library/ie/ms536761.aspx) isn't supported.  
>   
>  Displaying an entity form within an IFrame embedded in another entity form isn't supported.  

 You'll typically use the [getClientUrl](/powerapps/developer/model-driven-apps/clientapi/reference/Xrm-Utility/getGlobalContext/getClientUrl) method to retrieve the organization root Url for both on-premises [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] and [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)].  

<a name="BKMK_QueryStringParametersForMainForm"></a>   
### Query String Parameters for the Main.aspx Page  

> [!TIP]
>  To get the id value for any record, use the **Send a Link** button the command bar. The following is an example of what will be opened in your email application:  
>   
>  `<https://mycrm/myOrg/main.aspx?etc=4&id=%7b899D4FCF-F4D3-E011-9D26-00155DBA3819%7d&pagetype=entityrecord>`.  
>   
>  The id parameter passed to the URL is the encoded id value for the record. In this example the id value is `{899D4FCF-F4D3-E011-9D26-00155DBA3819}`. The encoded version of the GUID substitutes opening and closing brackets “{” and “}” with “%7B” and “%7D”, respectively,  

 The following are the query string parameters used with the main.aspx page to open entity forms or views:  


|  Parameter   |                                                                                                                                                                                                                                                                                                                                            Description                                                                                                                                                                                                                                                                                                                                            |
|--------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|   **etn**    |                                                                                                                                                                                                                                    The logical name of the entity. **Important:**  Don't use the **etc** (entity type code) parameter that contains an integer code for the entity. This integer code varies for custom entities in different organizations.                                                                                                                                                                                                                                     |
| **extraqs**  |     Optional for forms. This parameter contains encoded parameters within this parameter.<br /><br /> Use this parameter to pass values to a form. For more information, see [Set field values using parameters passed to a form](set-field-values-using-parameters-passed-form.md).<br /><br /> When an entity has more than one form defined, you can use this parameter to specify which form to open by passing the encoded parameter `formid` with the value equal to the ID value of the form. For example, to open a form with the ID of ‘6009c1fe-ae99-4a41-a59f-a6f1cf8b9daf’, include this value in the `extraqs` parameter: `formid%3D6009c1fe-ae99-4a41-a59f-a6f1cf8b9daf%0D%0A`.     |
| **pagetype** |                                                                                                                                                                                                                                                        The type of page. There are two possible values:<br /><br /> - **entityrecord**<br />     Displays an entity record form.<br />- **entitylist**<br />     Displays an entity view.                                                                                                                                                                                                                                                         |
|    **id**    |                                                                                                                                                                      Optional for forms. Use this when you open a specific entity record. Pass in the encoded GUID identifier for the entity. The encoded version of the GUID substitutes opening and closing brackets “{“ and “}” with “%7B” and “%7D”, respectively, for example `{91330924-802A-4B0D-A900-34FD9D790829}` is `%7B91330924-802A-4B0D-A900-34FD9D790829%7D`.                                                                                                                                                                      |
|  **viewid**  |                                                                                                                                                                                                        Required for views. This is the ID of the `savedquery` or `userquery` entity record that defines the view. The easiest way to get the URL for a view is to copy it. For more information, see [Copy the URL for a View](open-forms-views-dialogs-reports-url.md#BKMK_CopyViewURL).                                                                                                                                                                                                         |
| **viewtype** |                                                                                                                                                                                                        Defines the view type. Possible values are as follows:<br /><br /> - **1039**<br />     Use for a system view. The `viewid` represents the Id of a `savedquery` record.<br />- **4230**<br />     Use for a personal view. The `viewid` represents the Id of a `userquery` record.                                                                                                                                                                                                         |
|   `navbar`   | Controls whether the navigation bar is displayed and whether application navigation is available using the areas and subareas defined in the sitemap.<br /><br /> -   `on`<br />     The navigation bar is displayed. This is the default behavior if the `navbar` parameter isn't used.<br />-   `off`<br />     The navigation bar isn't displayed. People can navigate using other user interface elements or the back and forward buttons.<br />-   `entity`<br />     On an entity form, only the navigation options for related entities are available. After navigating to a related entity, a back button is displayed in the navigation bar to allow returning to the original record. |
|   `cmdbar`   |                                                                                                                Controls whether the command bar is displayed. **Note:**  This capability supports requirements for the [!INCLUDE[pn_unified_service_desk_for_crm](../includes/pn-unified-service-desk-for-crm.md)] application. Using this to display an entity form within an IFrame embedded in another entity form isn't supported. <br /><br /> -   `true`<br />     The command bar is displayed. This is the default.<br />-   `false`<br />     The command bar is hidden.                                                                                                                |

<a name="BKMK_CopyViewURL"></a>   
### Copy the URL for a View  
 Many views in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] let a user copy the URL for a particular view or send an email with the URL for a particular view embedded in the message. This feature makes communication between users easier, and exposes a way for you to gain access to a URL for a view that users can include in another application, such as a [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] site.  

> [!NOTE]
>  Don't use this URL to include the view in application navigation using the site map. For more information, see [Display a View in the Application Navigation using the Site Map](open-forms-views-dialogs-reports-url.md#BKMK_DisplayViewInApplicationUsingSiteMap).  

 The page displayed by the URL includes the full view. This includes the ribbon, but doesn't include the application navigation.  

##### Get the URL for a View  

1. Open the view you want to use.  

2. On the command bar, click **Send a Link**, and then click **Of Current View**.  

3. Paste the link into [!INCLUDE[pn_Notepad](../includes/pn-notepad.md)] and edit it to extract only the URL part of the text that you want.  

> [!NOTE]
> - Views that use the user context as a parameter, such as **My Accounts**, cannot be copied.  
>   - The GUID that represents system views for system entities will be the same for each on-premises [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] installation. The GUID for custom entities and custom views will be unique for each [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] installation.  

<a name="BKMK_DisplayViewInApplicationUsingSiteMap"></a>   
### Display a View in the Application Navigation using the Site Map  
 When you customize the application navigation using the site map, don't use the view URL that you copied from the application using the steps in [Copy the URL for a View](open-forms-views-dialogs-reports-url.md#BKMK_CopyViewURL) to set as the URL. 
 That URL displays a page that includes the ribbon and produces undesirable results if used in a `<SubArea>` Url attribute.  

 To display a list of entity records within the application for a SubArea set the Entity attribute value. This displays the default view for that entity and provides the correct title and icon.  


 However, if you want to have a SubArea element that uses a specific initial default view, use the following URL pattern when working with Unified Interface.

```
[Organization Url]/main.aspx?pagetype=entitylist&etn=<entity logical name >&viewid=%7b00000000-0000-0000-0000-000000000000%7d&viewType=1039
```

For the legacy web client, use the following URL.

```
[Organization Url]/homepage.aspx?etn=<entity logical name >&viewid=%7b00000000-0000-0000-0000-000000000000%7d  
```  

 When you use this URL, you must also specify appropriate values for `<Titles>` and `<Descriptions>`, and specify an icon for the entity.  

> [!NOTE]
>  If you specify the view using the `.../homepage.aspx` page, the view selector will still be shown. If the user changes the view, [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] remembers the user’s most recent selection and the initial default view displays after they close and re-open their browser.  

<a name="BKMK_OpenADialogProcess"></a>   
## Opening a Dialog Process by using a URL  
 A common customization is to enable a user to open a specific dialog process in the context of a specific record. For example, you might want to add a custom button to the ribbon for a specific entity using the id value for current record as an input parameter for the dialog process.  

 To open a dialog you need the following:  

-   The unique identifier for the dialog.  

-   The logical name for the entity the dialog is created for.  

-   The unique identifier for the record you want to have the dialog run against.  

> [!TIP]
>  To get the unique identifier for the dialog, navigate to **Settings**, in the default solution select **Processes**. Select a process and then in the **Actions** options on the command bar, click **Copy a Link**. This will copy a link to edit the dialog to your clipboard, for example, *[organization url]*`/sfa/workflow/edit.aspx?id=%7b6A6E93C9-1FE6-4C07-91A9-E0E2A7C70976%7d`.  

 The following sample shows the URL and query string parameters to open a dialog:  

```
[organization url]/cs/dialog/rundialog.aspx?DialogId=[dialog unique identifier]&EntityName=[entity logical name]&ObjectId=[unique identifier for the record]  
```  

 For example, to open the dialog with id ={6A6E93C9-1FE6-4C07-91A9-E0E2A7C70976} with the account record id = {40C9ADFD-90A8-DF11-840E-00155DBA380F}, use the URL in the following example.  

```
[organization url]/cs/dialog/rundialog.aspx?DialogId=%7b6A6E93C9-1FE6-4C07-91A9-E0E2A7C70976%7d&EntityName=account&ObjectId=%7b40C9ADFD-90A8-DF11-840E-00155DBA380F%7d  
```  

> [!TIP]
>  For browsers other than [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)], if a dialog process is opened from a link, the **Finish** button may not work. The data will be saved, but the user will need to click the **Close** button on the window to close it. This is because other browsers don't provide a `window.close` method if the window isn't opened using [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] from another window. When possible, use [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] and the `window.open` method to open dialog processes rather than simply providing links.  

 You can create a [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] function to open the dialog as shown in the following example:  

```javascript  
function openDialogProcess(dialogId, entityName, objectId)  
{  
 var url = Xrm.Page.context.getClientUrl() +  
  "/cs/dialog/rundialog.aspx?DialogId=" +  
  dialogId + "&EntityName=" +  
  entityName + "&ObjectId=" +  
  objectId;  
 window.open(url);  
}  
```  

<a name="BKMK_OpenReportWithURL"></a>   
## Opening a Report by using a URL  
 You can open a report by passing appropriate parameter values to the following URL: `[organization url]/crmreports/viewer/viewer.aspx`.  

 This URL accepts the following parameters:  

 **action**  
 Two possible values for this parameter are `run` or `filter`. When `run` is used, the report will be displayed using the default filters. When `filter` is used, the report will display a filter that the user can edit before choosing the **Run Report** button to view the report.  

 **helpID**  
 This parameter is optional. For reports that are included with [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] the value in this parameter allows the **Help** button to display appropriate content about this report when **Help on This Page** is chosen. The value should correspond to the report `FileName` attribute value.  

 **id**  
 This parameter is the report `ReportId` attribute value.  

 The following examples show URLs that can be used to open reports in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  

 Open the **Neglected Cases** report using the default filter:  
 ```  
 [organization url]/crmreports/viewer/viewer.aspx?action=run&helpID=Neglected%20Cases.rdl&id=%7b8c9f3e6f-7839-e211-831e-00155db7d98f%7d  
 ```  

 Open the **Top Knowledge Base Articles** report and prompt the user to set filter values:  
 ```  
 [organization url]/crmreports/viewer/viewer.aspx?action=filter&helpID=Top%20Knowledge%20Base%20Articles.rdl&id=%7bd84ec390-7839-e211-831e-00155db7d98f%7d  
 ```  

 The following function shows how to properly encode values in the URL:  

```javascript  
function getReportURL(action,fileName,id) {  
 var orgUrl = GetGlobalContext().getClientUrl();  
 var reportUrl = orgUrl +   
  "/crmreports/viewer/viewer.aspx?action=" +  
  encodeURIComponent(action) +  
  "&helpID=" +  
  encodeURIComponent(fileName) +  
  "&id=%7b" +  
  encodeURIComponent(id) +  
  "%7d";  
 return reportUrl;  
}  
```  

### See also  
 [Extend Dynamics 365 Customer Engagement (on-premises) on the client](extend-client.md)   
 [Set field values using parameters passed to a form](set-field-values-using-parameters-passed-form.md)   
 [Configure a form to accept custom querystring parameters](configure-form-accept-custom-querystring-parameters.md)   
 [Change Application Navigation using the SiteMap](customize-dev/change-application-navigation-using-sitemap.md)   
 [Customize the Ribbon for Dynamics 365 Customer Engagement (on-premises)](customize-dev/customize-commands-ribbon.md) 
 [Client scripting in Customer Engagement using JavaScript](clientapi/client-scripting.md) 
 [Web Resources for Dynamics 365 Customer Engagement (on-premises)](web-resources.md)   
 [Start Dialog by using a URL](../developer/actions-dialogs.md#StartDialog)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
