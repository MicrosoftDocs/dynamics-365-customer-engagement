---
title: "Unified Service Desk Release Notes | MicrosoftDocs"
description: "Learn about the known issues and limitations in Unified Service Desk."
keywords: ""
ms.date: 05/7/2018
ms.service: 
  - "usd"
ms.custom: 
  - ""
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: B0070DA6-803C-4F92-92E7-9524EDD7C1A2
author: kabala123
ms.author: kabala
manager: shujoshi
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---

::: moniker range="dynamics-usd-4"

# Unified Service Desk 4.0 known issues and limitations

## Known issues

This section describes the known issues in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]

## Select articles from the Unified Interface KB Control in the Unified Service Desk displays error

If you are using **Web client - Unified Interface Migration Assistant** to migrate your Unified Service Desk Configurations from Dynamics 365 Web Client to Dynamics 365 Unified Interface App, the KM Control is changed to Unified Interface KM Control.

With the Unified Interface KM Control hosted control, if you login to Unified Service Desk and open any KB article, you can server error.

![Opening article displays server error](media/kb-search-server-error.PNG "Opening article displays server error")

### Workaround

To fix the issue, you must manually update the data parameter for the Unified Interface KM Control action call.

In the Dynamics 365 Web Client configurations, got to the action call for opening the KM, and in the **Data** field you can see the parameters like **url**, **postdata**, and **header**.

![Action call with the postdata and header parameter](media/manual-update-unified-interface-km-control-action-call-data.PNG "Action call with the postdata and header parameter")

Remove the following values from the data field:

`postdata=[[postdata]]`

`header=[[header]+]` 

To open an KB article, only the article url is sufficient. For example: `url=[[KB Search.articleurl]g]`

Now, save the configuration. Login to Unified Service Desk and open any article to see the article contents.

![Remove the header and postdata parameter to see the article contents](media/kb-search-fix.PNG "Remove the header and postdata parameter to see the article contents")


## Toolbar shows Unified Blue theme instead Air theme

In the **Unified Interface Settings** record, select **Air** theme instead **Unified Blue** theme, and select an Unified Interface App. 

![Air theme is set in the Unified Interface Settings record](media/usd-crm-unified-interface-air-theme.png "Air theme is set in the Unified Interface Settings record")

Now, if you login to [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], the **About Tool Bar** and **Main** toolbar chooses to show **Unified Blue** theme colors instead **Air** theme.

![The main and about toolbar shows Unified Interface theme colors instead Air theme colors](media/about-toolbar-main-toolbar-known-issue.png "The main and about toolbar shows Unified Interface theme colors instead Air theme colors")

### Workaround

Remove the **Custom Styles** XAML from the **About Tool Bar** and **Main** toolbar so that toolbar picks the **Air** theme colors.

1. Sign in to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]

2. Go to **Settings** > **My Apps** > **Unified Service Desk Administrator** app.<br>

3. Select **Site Map**.</br>
![Select Site Map to go to Unified Interface Settings](media/usd-crm-site-map-unified-interface-setting.PNG "Select Site Map to go to Unified Interface Settings")

4. Choose **Toolbars** under the **Basic Settings**.

5. Select **About Tool Bar** from the list.

6. Choose the **Styles** tab.

7. Remove the content in the **Custom Styles** field.

8. Select **Save** to save the settings. 

Repeat the steps 5-8 for the **Main** toolbar.

Login to [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] and toolbar chooses **Air** theme colors.

![The main and about toolbar shows Air theme colors](media/about-toolbar-main-toolbar-known-issue-fixed-toolbar.png "The main and about toolbar shows Air theme colors")

## Unified Interface form does not close the tab and navigates to Dashboard

Go to **Settings** > **Administration** > **System Settings** and set the **Enable auto save on all forms** to **No** in Dynamics 365 Unified Interface. 

![Disable autosave in Unified Interface forms](media/crm-unified-interface-disable-autosave.png "Disable autosave in Unified Interface forms")

Now, login to [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], and open any Unified Interface page. For example, open a case. After completing your work on the case, if you select **Save & Close** on the Unified Interface page (form), the form saves and closes.

![Select Save & Close on Unified Interface forms](media/usd-crm-saveclose.png "Select Save & Close on Unified Interface forms")

However, the tab does not close, and the Unified Interface page (form) navigates to **Dashboard** page.

![Unified Interface page navigates to Dashboard page](media/usd-crm-page-navigates-dashboard.png "Unified Interface page navigates to Dashboard page")

### Workaround

To close the tab, you need to select **User Can Close** in the hosted control so that you see **X** button the tab in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. 

![Set user can close option in the hosted control](media/usd-crm-usercanclose-option.png "Set user can close option in the hosted control")

Now, login to [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], and open the case. Now, select **Save & Close** on the Unified Interface page (form), the form saves and closes. The page navigates to the **Dashboard** page. To close the tab, you can select the **X** button.

![Select close button to close the tab](media/usd-crm-close-button-saveclose.png "Select close button to close the tab")

## Sub Actions Calls is not available in Unified Service Desk Administrator app

You cannot view and attach an action call to another call (sub-action call) in Unified Service Desk Administrator app as the **Action Calls** in Unified Service Desk Administrator app does not display the **Sub Action Calls** option in the related tab. .

### Workaround

You can add an action call to another call using the Unified Service Desk configurations in Dynamics 365 Web Client. 

## Limitations

This section describes the limitations in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]

## Support for Relevance Search (search technique) in Unified Interface KM Control

The Unified Interface KM Control supports [Full-Text search](https://docs.microsoft.com/en-us/sql/relational-databases/search/full-text-search?view=sql-server-2017) technique in Dynamics 365 and does not support the **Relevance Search**. For more information about the availability of the Relevance Search, see [Relevance search for knowledge management](https://docs.microsoft.com/en-us/business-applications-release-notes/October18/service/customer-service-core-release-notes/relevance-search-for-knowledge-management).

## Quick create in Unified Service Administrator app

Selecting the **New** button (quick create)  in the **Navigation** toolbar of the Unified Service Desk Administraor app does not display any option to create.

![Quick create option in the Navigation toolbar](media/usd-crm-quick-create-button.PNG "Quick create option in the Navigation toolbar")

## Navigation and command bar configuration does not execute when Internet Explorer pooling is enabled

By default, when you a open Dynamics 365 page in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application, the navigation bar is hidden and command bar is displayed. 

However, when you enable Internet Explorer pooling and change the configurations in Dynamics 365 to hide the command bar and display the navigation bar, the Dynamics 365 page in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application does hide the command bar and display the navigation bar.

To execute the configuration, disable the Internet Explorer pooling.

## See Also

[Unified Interface KM Control (hosted control)](unified-interface-km-control-hosted-control.md)

::: moniker-end

::: moniker range="dynamics-usd-3"

# Unified Service Desk 3.3 known issues and limitations

This section describes the known issues and limitations in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]

## Known issues

## Best Practices Analyzer

- **Warning for HelpImproveUSD parameter in Dynamics 365 (on-premises)**

  Help Improve [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] is enabled/disabled only for [!INCLUDE[pn-crm-online](../includes/pn-crm-online.md)]. If you are using [!INCLUDE[pn-crm-onprem](../includes/pn-crm-onprem.md)], you can see a warning for the Help Improve [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] (HelpImproveUSD) parameter in the report.

- **Error for Enable Enhanced Protected mode in Windows 7 operating system**

  If you are using [!include[pn-windows-7](../includes/pn-windows-7.md)] operating system, the **Enable Enhanced Protected Mode** option is not available in Internet Explorer options. Hence, you can see an error message for the **Enable Enhanced Protected Mode** parameter in the report.

## Provide Feedback

- **Insufficient permissions to provide feedback**

  The **Provide Feedback** feature is available only if you have a [!INCLUDE[pn-crm-online](../includes/pn-crm-online.md)] instance.

  If you log in using administrator credentials and select **Provide Feedback** to provide your feedback/comments, you can see an **Insufficient Permissions** message. 

  ![Insufficient Permissions](media/insufficient-permissions-provide-feedback-window.PNG "Insufficient Permissions")

  The message says to contact the administrator even though you log in as an administrator. The reason for this message is that you did not enable the **HelpImproveUsd** option in the UII global options.

  If you enable **HelpImproveUsd**, the data collection is enabled, and in turn, you (agent and administrator) can provide feedback to improve the product.

  To enable **HelpImproveUsd**, view [Help improve Unified Service Desk](admin/help-improve-unified-service-desk.md).

## Limitations

This section describes the limitations in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]

## RunScript

> [!IMPORTANT]
> This also applies to:
> - [!INCLUDE[pn-unified-service-desk-3-2](../includes/pn-unified-service-desk-3-2.md)]
> - [!INCLUDE[pn-unified-service-desk-3-1](../includes/pn-unified-service-desk-3-1.md)]
> - [!INCLUDE[pn-unified-service-desk-3-0](../includes/pn-unified-service-desk-3-0.md)]
> - [!INCLUDE[pn-unified-service-desk-2-2](../includes/pn-unified-service-desk-2-2.md)]

**RunScript action does not execute if the tab or page is not in focus**

If you execute a RunScript action on a tab or a page that is not in focus, the execution of RunScript action does not execute the script.

**Example:**

Accounts and Contacts tabs are open and focus is on Accounts tab. You execute `window.close()` RunScript command to close the Contacts tab. Since, the focus is on Accounts tab the RunScript execution does not execute and the Contacts tab does not close.

**Workaround:**

If you open several tabs and want to execute a RunScript action on a tab that is not in focus, set the focus on the tab you want to work and then execute the RunScript action.

## Performance enhancement for CRM entity page loads

> [!IMPORTANT]
> This also applies to:
> - [!INCLUDE[pn-unified-service-desk-3-2](../includes/pn-unified-service-desk-3-2.md)]

**Closing CRM entity page starts loading but never completes loading**

When **InternetExplorerPooling** is enabled, and if you close a CRM entity page hosted in Unified Service Desk using the close (**x**) button (_see Image 1_), the CRM entity page to starts loading but never completes loading (_see Image 2_).

  ![Closing CRM entity page hosted in Unified Service Desk using close button](../unified-service-desk/media/usd-crm-page-hosted-close-button.PNG "Closing CRM entity page hosted in Unified Service Desk using close button")
    
  _Image 1: Closing CRM entity page hosted in Unified Service Desk using close (x) button_
  
  ![CRM entity page start loading but never completes loading](../unified-service-desk/media/usd-crm-page-hosted-never-completes-loading.PNG "CRM entity page start loading but never completes loading")
  
  _Image 2: CRM entity page start loading but never completes loading_

**Workaround**

If you close the CRM entity page, the page starts loading but never completes the loading. In this case, to restore the CRM entity page, right-click on CRM entity page and select **Forward** from the context menu (_see Image 1_).

![Right-click on the CRM entity page and select Forward from the context menu](../unified-service-desk/media/usd-crm-page-right-click-CRM-entity-page-select-forward.PNG "Right-click on the CRM entity page and select Forward from the context menu")

_Image 1: Right-click on the CRM entity page and select Forward from the context menu_

> [!Note]
> The session that you are working is fine and there is no data loss.

## Clicking back button in a session does not perform navigation to original URL

If you open any webpage in the browser with hosted controls using IE Process hosting method, the webpage opens in a new window within the same-hosted control overlaying the existing page/window. 

Since the webpage is opened in the new window within the same hosted control overlaying the existing page or window, clicking the back button in the webpage does not perform the navigation back to the original page. This behavior is that the new window does not have any history to navigate back to the original page.

**Workaround**

Configure **Show Outside** action call to show the webpage in an **IE process** outside of the hosted control space in the popup window.

### Step 1: Configure ShowOutside action call

In this step, you will create an action call to show the webpage.

1. Sign in to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].
2. [!INCLUDE[proc_settings_usd](../includes/proc-settings-usd.md)]
3. Clikc **Action Calls**.
4. Click **+ New**.
5. On the **New Action Call** page, specify the following values.
  
   | Field | Value |
   |----------|-----------|
   |Name | Show Outside |
   |Hosted Control | CRM Global Manager|
   |Action| LaunchURL|
   |Data| [[SUBJECTURL]]|

   ![Show outside Action Call](media/show-outside-action-call.PNG "Show outside Action Call")
6. Click **Save**.

### Step 2: Configure Window Navigation Rules and add the Action Call

In this step you will create a navigation rule and set the order before other default rules. After creating the navigation rule, add the **ShowOutside** action call that you created in Step 1 to the **Show Outside Rule** window navigation rule.

1. Sign in to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].
2. [!INCLUDE[proc_settings_usd](../includes/proc-settings-usd.md)]
3. Click **Window Navigation Rules**.
4. Click **+ New**.
5. On the **New Window Navigation Rules** page, specify the following values.

   | Field | Value |
   |-------------|----------------|
   |Name| Show Outside Rule|
   |Order | 1 <br> **Note:** You can specify any order that is lesser than the default list of Window Navigation Rules. |
   | Url | https://www.bing.com <br> **Note:** You must to specify a URL to which you want to navigate.|
   |Route Type | Popup |
   | Destination | Tab |
   |Action | None |

   ![Show outside Window Navigation Rule](media/show-outside-navigation-rule.PNG "Show outside Window Navigation Rule")

6. Click **Save**.
7. On the nav bar, click the down arrow next to **Show Outside Rule**, and click **Actions**.
8. On the next page, click **ADD EXISTING ACTION CALL**, type **Show Outside** in the search bar, and then press **ENTER** or click the search icon.
9. Click **Save**.

The configuration of action call and window navigation rule is completed. If you now open a webpage, the webpage opens as a popup in a new window.

For more information related to this limitation, refer the [Unified Service Desk Blogs](https://blogs.msdn.microsoft.com/usd/2017/09/27/unified-service-desk-best-practices-part-5-open-pdf-files-in-an-ie-process-hosted-control/)

## See also

[Analyze best practices in Unified Service Desk](admin/analyze-best-practices-unified-service-desk.md)

[Performance enhancement for CRM entity page loads](admin/performance-enhancement-CRM-entity-page-loads.md)

[Help improve Unified Service Desk](admin/help-improve-unified-service-desk.md)

::: moniker-end