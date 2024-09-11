---
title: Troubleshoot LinkedIn Sales Navigator integration errors with Dynamics 365
description: Explore solutions for LinkedIn Sales Navigator integration errors with Dynamics 365, including data validation failures and display widget issues.
ms.date: 09/06/2024
ms.topic: troubleshooting
author: udaykirang
ms.author: udag
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:06/27/2024
---

# Troubleshoot LinkedIn Sales Navigator integration errors with Dynamics 365

This article helps you troubleshoot and resolve issues related to LinkedIn integrations in Dynamics 365 Sales.

## Error in enabling LinkedIn updates

**Reason**

When enabling the data validation option (**Enable LinkedIn updates**) in the **Sales Navigator Integration Settings** dialog box, you might see the status that data validation has failed. The possible errors are:  

- Data validation has failed because CRM sync is disabled in LinkedIn Sales Navigator.
- Data validation failed with some other error (for example, an "unexpected error").

:::image type="content" source="media/lisn-update-error.png" alt-text="Screenshot of Error in enabling LinkedIn updates.":::

For more information about the data validation capability of LinkedIn Sales Navigator, see [Data validation](./data-validation.md).

**Resolution**

- If you get the data validation failure because CRM sync was disabled, verify the following:

    - CRM sync is enabled in LinkedIn Sales Navigator.  
    - The setting for data validation is enabled in LinkedIn Sales Navigator. If this setting isn't turned on, you'll see the CRM sync disabled status even though CRM sync is enabled. If you aren't able to see the data validation setting in LinkedIn Sales Navigator, ensure that you have an appropriate Sales Navigator license. More information: [Sales Navigator Data Validation - Overview](https://www.linkedin.com/help/sales-navigator/answer/a120992)  
    - If you've turned on both the settings, ensure that you've turned on the **Enable LinkedIn updates** setting at least once.

- If the error is due to something other than CRM sync, you can try restarting data validation by first disabling it from the **Sales Navigator Integration Settings** dialog box, and then enabling it again.

## Unable to upgrade the LinkedInSalesNavigatorForUnifiedClient solution  

**Reason**  

You're unable to upgrade the **LinkedInSalesNavigatorForUnifiedClient** solution from 1.*x* to 3.*x*. This issue occurs because of the dependencies that exist for the solution: you can’t update the solution that has dependencies associated with it. 

**Resolution**  

To resolve this issue, you must remove the existing dependencies for the **LinkedInSalesNavigatorForUnifiedClient** solution. Follow these steps: 

1. For the current **LinkedInSalesNavigatorForUnifiedClient** solution, remove the dependencies and uninstall the solution. For more information, see step 4 in [Uninstall LinkedIn Sales Navigator](uninstall-sales-navigator.md).  
1. Uninstall the **msdyn_LinkedInSalesNavigatorAnchor** solution.  
1. After the solutions are successfully deleted, install them again. More information: [Install and enable LinkedIn Sales Navigator](install-sales-navigator.md)  

## LinkedIn Sales Navigator display widgets are not loading properly on different web browsers

**Reason**

When I try to sign in to LinkedIn Sales Navigator, errors are displayed. These errors occur due to the enablement of track protection in the browser. The following are the errors:

- Display widgets are showing the error&mdash;*LinkedIn Sales Navigator subscription not found. You need a LinkedIn Sales Navigator Team contract in order to gain access*.  

    :::image type="content" source="media/display-widget-subscription-not-found-error.png" alt-text="Screenshot of display widgets show subscription not found error.":::

-OR-  

- Display widgets are not loading on different browsers. The error is displayed as shown in the following sample image:  

    :::image type="content" source="media/display-widget-not-loading-error.png" alt-text="Screenshot of display widgets are not loading.":::

**Resolution**

To resolve this issue, you must disable the track protection in the browser ([Microsoft Edge](#microsoft-edge), [Mozilla FireFox](#mozilla-firefox), [Google Chrome](#google-chrome), and [Apple Safari](#apple-safari)). 

Microsoft Edge:<a name='microsoft-edge'></a>  

1. Open the Microsoft Edge browser.  
1. Select the **More options** icon on the top-right and go to **Settings**.  
1. From the site map, go to **Privacy, search, and services**.  
1. In the **Tracking Prevention** section, select **Balanced** and disable the **Always use “Strict” tracking prevention when browsing InPrivate** option.  

    :::image type="content" source="media/edge-select-browser-settings.png" alt-text="Screenshot of configuring track prevention section in edge.":::

Mozilla FireFox:<a name='mozilla-firefox'></a>  

1. Open the Mozilla FireFox browse and open your organization.  
1. Before the address bar, select the shield icon and the Enhanced tracking protection details appears.  
1. Disable the **Enhanced tracking protection is ON for the site** option and refresh the browser.  

    :::image type="content" source="media/firefox-select-browser-settings.png" alt-text="Screenshot of configuring track prevention section in firefox.":::

1. Refresh the page and the display widgets start loading as expected.

Google Chrome:<a name='google-chrome'></a>  

In the Chrome browser, the display widgets loading issue could occur in Incognito/Private mode.  
While browsing the org in Incognito/Private mode, disable the **Block third-party cookies** option. The display widgets load as expected.  

:::image type="content" source="media/chrome-select-browser-settings.png" alt-text="Screenshot of configuring track prevention section in chrome.":::

Apple Safari:<a name='apple-safari'></a>

1. Open the Apple Safari browse and open your organization.
1. Go to **Preferences** and configure the following options:

    - LinkedIn and your Dynamics 365 organization is not present in the block list of **Content Blockers**.  
    - Your Dynamics 365 organization allows pop-up windows.  
    - In **Privacy** tab, the **Prevent cross-site tracking** and **Block all Cookies** options are not selected.  

## Unable to view photos on custom contact and lead forms in Unified Interface  

**Reason**  

By default, the photos from LinkedIn are displayed on the out-of-the-box Contact and Lead forms. For custom forms, you can't have the photos displayed by default.  

**Resolution**  

To resolve this issue, add the **msdyn_linkedinintegrationcommon.js** library and the **LinkedInIntegration.LinkedInIntegrationCommon.Instance.Form_OnLoad** function handler to your custom forms. Follow these steps:  

1. Sign in to your Dynamics 365 app.  
1. Go to **Advanced Settings** > **Customizations** > **Customize the System**.  
1. From the **Entities** site map, select the entity and then custom form for which you want to display the photo.  

    >[!NOTE]
    >In this procedure, we are using contact custom form.  

1. Select the **Form Properties** option.  

    The **Form Properties** dialog opens.  

    :::image type="content" source="media/ts-linkedin-contact-form-properties.png" alt-text="Screenshot of the Form properties dialog box.":::

1. In the **Form Libraries** section, search and add the **msdyn_linkedinintegrationcommon.js** library to the form.  
1. In the **Event Handlers** section, search and add the **LinkedInIntegration.LinkedInIntegrationCommon.Instance.Form_OnLoad** function to the form.  

    :::image type="content" source="media/ts-linkedin-contact-form-properties-added.png" alt-text="Screenshot of adding LinkedIn library and function to the form.":::

1. Save and publish the form.  

<a name="solution-missing-configure-lsn"></a>
## The LinkedInSalesNavigatorControlsForUnifiedClient solution is not available in the organization to configure LinkedIn Sales Navigator  

**Reason**  
The **LinkedInSalesNavigatorControlsForUnifiedClient** solution will be available only in organizations with LinkedIn Sales Navigator solution version 2.2.0.1 and above. If LinkedIn solution version is less than 2.2.0.1, then install the **LinkedInSalesNavigatorControlsForUnifiedClient** solution manually. 

**Resolution**  
To resolve this issue, delete the solutions and reinstall them again.  

>[!NOTE]
>Deleting and installing the solution can result in loss of data for **li_inmails**, **li_message**, and **li_pointdrivepresentationviewed** entities. Export data from these entities and restore when installed.  

Follow these steps:  

1. Delete the LinkedIn Sales Navigator solution. Before deleting the solution verify the dependencies, if exists, contact your System administrator to remove the solutions. To remove the dependencies, follow these steps:  
    1. Go to **Advanced settings** > **Customization** > **Solutions**.  
    1. Select the LinkedIn solution and then **Show Dependency**.  

        :::image type="content" source="media/ts-solution-dependencies.png" alt-text="Screenshot of LinkedIn solution dependencies.":::

    1. Select **Required by** entity name and the dependent entity opens in a page.  
    1. Select **Form Properties** and under the **Events** tab go to the **Event Handlers** section.  
    1. Select and remove the events.  
    1. Save and publish the customization.  

1. Delete the **msdyn_LinkedInSalesNavigatorAnchor** solution.
1. Install the **LinkedIn Sales Navigator** solution again and restore the data for the entities.
 
## Related information

[Dynamics 365 Sales troubleshooting guide](../sales-enterprise/troubleshooting.md)
