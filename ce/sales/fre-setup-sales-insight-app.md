---
title: "First-run setup experience for conversation intelligence"
description: "First-run configuration of conversation intelligence for Microsoft Teams and conversation intelligence application for your Dynamics 365 Sales environment."
ms.date: 10/26/2021
ms.custom: 
ms.topic: article
ms.assetid: 3e099e3a-f6cb-42cf-b84e-9f8b0c6ee9db
author: udaykirang
ms.author: udag
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 1
topic-status: Drafting
---

# First-run setup experience for conversation intelligence

You can configure conversation intelligence with Microsoft Teams by completing the following section:

- [Microsoft Teams for conversation intelligence](#microsoft-teams-for-conversation-intelligence)
- [The conversation intelligence application](#the-conversation-intelligence-application)

After you sign in to conversation intelligence or your sales app, you can set up conversation intelligence depending on the role that's assigned to you:
 
- As an administrator, you can set up the complete application&mdash;enable Microsoft Teams call recording for conversation intelligence preview, select storage, grant app permissions, and define organization-level tracked keywords and competitors to be used by conversation intelligence.
- As a sales manager or a seller, you'll need an administrator to configure the application so you can view the data and settings that are relevant to you. More information: [Configure sales team level settings](configure-sales-team-level-settings.md)

## License and role requirements

| &nbsp; | &nbsp; |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security Role** | System Administrator <br>  See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## Microsoft Teams for conversation intelligence

> [!IMPORTANT]
> - The enhanced experience for Microsoft Teams together with conversation intelligence is a preview feature. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
> - [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
> - [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)] 

Using Teams together with conversation intelligence in Dynamics 365 Sales helps organizations transform customer interactions into revenue. Calling with Teams allows business-critical insights to be surfaced both in real time (during the call) and post-call, insights that are seamlessly tied to the relevant Dynamics 365 records.

### Review the prerequisites

Review the following requirements before you configure Teams call recording for conversation intelligence:

- Your organization has a Teams phone system installed with a valid license to use it. More information: [Set up Phone System in your organization](/microsoftteams/setting-up-your-phone-system)
- You have a license to use Teams. More information: [Microsoft Teams add-on licenses](/microsoftteams/teams-add-on-licensing/microsoft-teams-add-on-licensing?tabs=small-business)
 
### Enable calling with Teams 

Before you can proceed to configuring Teams with conversation intelligence, you must enable the Teams dialer for your organization. More information: [Configure Microsoft Teams dialer](/dynamics365/sales-enterprise/configure-microsoft-teams-dialer)
 
### Run the PowerShell script to record calls

Before you configure the Teams dialer, run the PowerShell script to enable recording of your Teams calls. These call recordings are used for processing and analysis. The PowerShell script creates:

- An Azure Active Directory (Azure AD) security group for which the recording will be enabled.
- Teams call recording–related artifacts, such as service principal and recording policy.

Follow these steps:

1. [Download the PowerShell script](#download-the-powershell-script)   
2. [Configure the PowerShell script](#configure-the-powershell-script)   

#### Download the PowerShell script

1.	Sign in to the Dynamics 365 Sales Hub app as a Dynamics 365 system administrator.    

2.	Select the **change area** ![change area.](media/change-area-icon.png) in the lower-left corner of the page, and then select **Sales Insights settings**.  
    > [!div class="mx-imgBorder"]
    > ![Select Sales Insights settings.](media/si-admin-change-area-sales-insights-settings.png "Select Sales Insights settings")   

3.	On the site map, under **Productivity**, select **Conversation intelligence**.   
    The conversation intelligence home page opens.   

    > [!div class="mx-imgBorder"]
    > ![Conversation intelligence home page.](media/ci-admin-getting-started-page.png "Conversation intelligence home page")   

4.	On the home page, select **Get started**.
    The conversation intelligence configuration page opens.

5.	In the **Microsoft Teams Call Recording** section, verify that the application has validated the successful configuration of the Teams dialer.    
    > [!div class="mx-imgBorder"]
    > ![Download the PowerShell script.](media/ci-admin-download-powershell-script.png "Download the PowerShell script")    

6.	Next to **Run PowerShell script**, select **Download**.   

#### Configure the PowerShell script

>[!IMPORTANT]
>You must have tenant administrator privileges to run the PowerShell script. 
  
1.	Open a PowerShell command window as administrator and verify that you have the latest PowerShell version. Run the following commands, and close the PowerShell window:
    -	`Install-PackageProvider -Name NuGet -Force`
    -	`Install-Module -Name PowerShellGet -Force -AllowClobber`
  
2. Open a new PowerShell command window and install the dependencies by running the following commands:    
    -	`Install-Module -Name MicrosoftTeams -RequiredVersion 1.1.6 -Force -AllowClobber`
    -	`Install-Module AzureAD`
    -	`Install-Module MSAL.PS`     

3.	Go to the downloaded script location and run the following command:     
    ```.\MediaRecordingTenantProvisioning.ps1```     
    The package installation begins, and a sign-in dialog opens.     

4.	Enter your tenant administrator credentials to sign in to your organization.

    >[!NOTE]
    >You'll be asked to provide credentials thrice.

5.	After the script is installed, go back to the Sales Hub app and select **Check status** to validate that the script has been installed successfully.

You can proceed to configure Teams with conversation intelligence.

>[!NOTE]
><a name="teams-tenant-admin-contact"></a>If any of the validations fail, you can't proceed with the configuration.  
>- To set up the phone system and Teams for your organization, contact your Teams administrator. 
>- To run the PowerShell script, contact your tenant administrator. More information: [Configure the PowerShell script](#configure-the-powershell-script) 

### Configure Microsoft Teams call recording

1.	Sign in to Dynamics 365 Sales Hub.

2.	Select the **change area** ![change area.](media/change-area-icon.png) in the lower-left corner of the page, and then select **Sales Insights settings**.  
    > [!div class="mx-imgBorder"]
    > ![Select Sales Insights settings.](media/si-admin-change-area-sales-insights-settings.png "Select Sales Insights settings")

3.	On the site map, under **Productivity**, select **Conversation intelligence**.     
    The conversation intelligence home page opens.    

4.	In the **Microsoft Teams call recordings (preview)** section, enable the preview and then configure the other settings as described in the following table.

    | Option | Description |
    |--------|-------------|
    | Enable recording for | Specifies the security roles in your organization who have permission to record calls by using the teams dialer. By default, permission is granted to all security roles in your organization. To only allow specific roles to access the feature, select **Specific security roles** and then use the lookup to select the roles. <br> **Tips:**<br><ul><li>To implement the feature in your entire organization, select all security roles.</li><li>For a phased implementation in your organization, create different security roles for each group of users and then assign the security role accordingly.</li></ul>|
    | Call recording options | Select an option for initiating call recordings:<br><ul><li>**Manual recording**: Select this option to allow sellers to manually start or stop the recording when a call is initiated. Also, you can select the checkbox to record only the seller automatically when the call is initiated. However, sellers can start or stop the recording of the customer anytime during the call. </li><li>**Automatic recording**: Select this option if you want the calls to be automatically recorded when a call is initiated. Also, you can select the checkbox to allow sellers to manually stop the recording anytime during the call.</li></ul>|
    | Recording notification for customers | Turn on this toggle to notify customers when the call recording is initiated. This lets customers know that the call is being recorded.|   
    
    > [!div class="mx-imgBorder"]
    > ![Enable Teams call recording preview.](media/ci-admin-enable-teams-preview.png "Enable Teams call recording preview")     

    >[!NOTE]
    >You only need to configure Teams call recording settings, storage selection, and conversation tracking for first-time onboarding to conversation intelligence. All remaining steps are optional. You can choose to configure them now or later, as needed.

5.	(Optional) Under **Call recording storage**, configure the storage-related options as described in the following table.

    | Option | Description |
    |--------|-------------|
    | Storage for call recordings | Select an option to store your call recordings for analysis:<br><ul><li>**Microsoft provided storage**: Select this option if you want to use the storage provided by Microsoft. By default, this option is selected, and we recommend that you use this storage.</li><li>**Your own Azure storage**: Select this option if you want to use your custom Azure storage. After you select this option, enter the **Storage connection string** and **Container name**.</li></ul>More information: [Configure conversation intelligence to connect call data](configure-conversation-intelligence-call-data.md) |
    | Retention policy | Choose a retention time limit. The application retains call recording data for the specified time limit, and deletes it when the time limit is reached. More information: [Call recording storage](data-retention-deletion-policy.md#call-recording-storage). |   

    > [!div class="mx-imgBorder"]
    > ![Select a storage option and retention policy.](media/ci-admin-teams-choose-storage-retention-policy.png "Select a storage option and retention policy")

    >[!NOTE]
    >For Microsoft-provided storage, the available retention periods are 30 days and 90 days. If your organization requires longer retention periods, please consider using your own storage.

6.	Under **Conversation tracking**, add the keywords and competitors that your organization wishes to track during calls, and add the languages used by sellers during calls with customers.

    This is a required global setting that will be applied to all sales calls in the organization. To enable conversation intelligence, you must set at least one global keyword and at least one global competitor. You can update these keywords and competitors later if necessary. More information: [Configure keywords and competitors in conversation content](configure-keywords-competitors.md)
        
    > [!div class="mx-imgBorder"]
    > ![Configure conversation tracking.](media/ci-admin-conversation-trackers.png "Configure conversation tracking")

7.	(Optional) In the **Privacy** section, you can select the checkbox to allow Microsoft to improve the quality of insights by giving read-only access to your organization's data in conversation intelligence.  

    > [!div class="mx-imgBorder"]
    > ![Enable privacy.](media/ci-admin-enable-privacy.png "Enable privacy")

8.	In the **License usage** section, you can view information about the total call recording processing hours that have been used, and how many available hours remain.

    > [!div class="mx-imgBorder"]
    > ![View license usage information.](media/ci-admin-license-usage.png "View license usage information")

9.	(Optional) In the **Coming soon** section, select the **Access new features before they're released to all our customers** checkbox to turn on the "coming soon" feature.

    If you don't want to enable preview features for your organization, skip this step. You can always enable them later. More information: [Enable coming soon features](../sales/enable-preview-features-sales-insights-app.md)  

    > [!div class="mx-imgBorder"]
    > ![Enable coming soon features.](media/ci-admin-coming-soon-features.png "Enable coming soon features")  

10.	Select **Publish**. In the message that appears, read the terms and conditions and the privacy statement. Select **Agree and continue**.      

    > [!div class="mx-imgBorder"]
    > ![Agree to terms and conditions to publish the configurations.](media/ci-admin-agree-terms-conditions-to-publish.png "Agree to terms and conditions to publish the configurations")    

Teams call recording with conversation intelligence is now configured and ready for use in your organization.

## The conversation intelligence application

1.	Review the prerequisites. More information: [Prerequisites to setup conversation intelligence](prereq-sales-insights-app.md)  
2.	Sign in to the conversation intelligence application as an administrator.  
    > [!div class="mx-imgBorder"]
    > ![Administrator conversation intelligence home page.](media/si-app-admin-home-page-admin-signin.png "Administrator conversation intelligence home page")   
3.	Select **Set up Conversation intelligence**.   
4.	In the **Connect your data** dialog, select your Dynamics 365 Sales environment to connect with the application.  
    > [!div class="mx-imgBorder"]
    > ![Select Dynamics 365 Sales environment.](media/si-app-admin-connect-d365-organization.png "Select Dynamics 365 Sales environment")    
    The application detects your environment.  
5.	In the **Terms and conditions** dialog, carefully read the [Microsoft privacy statement](https://privacy.microsoft.com/privacystatement), and read and select the checkbox for the [terms and conditions](https://www.microsoft.com/licensing/product-licensing/products). Select **Agree and continue**.  
    > [!div class="mx-imgBorder"]
    > ![Accept terms and conditions.](media/si-app-admin-accept-tandc.png "Accept terms and conditions")  
    >[!NOTE]
    >Selecting the first checkbox allows Microsoft to collect your organization's data to improve the quality of insights. This is optional. 
    The application takes a few minutes to connect to your data, during which a progress dialog is displayed.
    > [!div class="mx-imgBorder"]
    > ![Environment connection progress.](media/si-app-admin-connection-progress-d365-org.png "Environment connection progress")    
6.	In the **Connect your call data** dialog, enter the **Storage connection string** and **Container name**, and then select **Connect**. More information: [Configure conversation intelligence to connect call data](configure-conversation-intelligence-call-data.md)  
    > [!div class="mx-imgBorder"]
    > ![Enter values to connect call data.](media/si-app-admin-connect-call-data.png "Enter values to connect call data")   
7.	If you want to turn on access to preview features, in the **Coming soon** dialog, select the checkbox and then select **Agree and continue**.  
    > [!div class="mx-imgBorder"]
    > ![Turn on preview features.](media/si-app-admin-enable-preview-feature.png "Turn on preview features")   

    > [!NOTE]
    > If you don't want to enable the preview feature for your organization, skip this step. You can always enable preview features later. More information: [Enable coming soon features](enable-preview-features-sales-insights-app.md)  
8.	In the **Keyword and competitor tracking** dialog, add the keywords and competitors that you want to track on the call. You can update these keywords and trackers later if your organization's requirements change. More information: [Configure conversation content](../sales/configure-keywords-competitors.md)      
    > [!NOTE]
    > You can also skip adding the keywords and competitors at this point. You can always add them later.  
    
    > [!div class="mx-imgBorder"]
    > ![Add tracked keywords and competitors.](media/si-app-admin-keywords-and-competitor-tracking.png "Add tracked keywords and competitors")   
9.	Select **Finish** to complete the setup of conversation intelligence for your organization.
    The status message will be displayed at the top of the page.  
    > [!div class="mx-imgBorder"]
    > ![Setup progress message.](media/si-app-admin-status-message-set-up.png "Setup progress message")

Now your conversation intelligence application is ready, and managers and sellers can use it to view this data.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also

[Introduction to administering conversation intelligence](intro-admin-guide-sales-insights.md#administer-conversation-intelligence)  
[Prerequisites to configure conversation intelligence](prereq-sales-insights-app.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
