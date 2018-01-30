---
title: "Preview feature: Configure Relationship Insights features for Dynamics 365 Customer Engagement  | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: f2ba3ad4-96a0-47a9-a54a-71265f4d8053
caps.latest.revision: 28
author: "udag"
ms.author: "udag"
manager: "sakudes"
---
# Preview feature: Configure Relationship Insights features to better understand customer interactions

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

<a name="GettingStarted"></a>  
 
## Getting started  
Relationship Insights is not enabled by default. You need to enable each feature before you can use it. You can enable and use each feature individually or in any combination. To enable a feature, you must be a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] administrator.  
  
1. [!INCLUDE[proc_settings_administration](../includes/proc-settings-administration.md)]  
  
2.  Choose **System Settings**, and then select the **Previews** tab.  
  
3.  Read the [license terms](http://go.microsoft.com/fwlink/p/?LinkId=511446), and if you agree, select the **I’ve read and agree to the license terms** check box.  
  
 ![Previews settings dialog](../admin/media/previews-settings-dialog.png "Previews settings dialog")  
 
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [What are Preview features and how do I enable them?](what-are-preview-features-how-do-i-enable-them.md) 

4.  Go to **Settings** > **Relationship Insights** section, read and accept the Terms and Conditions, and then select **Install**.

5.  Select the Relationship Insights solution and then select **Manage**. 
 
   ![Select the Relationship Insights solution](media/relationship-insights-select-solution.png)
 
6.  Choose the Dynamics 365 Instance, accept the License Terms, and select **Install**.
    
   ![Install Relationship Insights solution](media/relationship-insights-install-button.png)

Once the solution is installed, proceed through the steps below to activate and configure the Relationship Insights features you want to be available to your organization.
  
<a name="Prerequisites"></a>   

## Requirements and prerequisites  
 There are some feature restrictions depending on which versions of [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] and [!INCLUDE[pn_Microsoft_Exchange](../includes/pn-microsoft-exchange.md)] you are running, as detailed in the following table.  
  
|Product version|Available Relationship Insights features|  
|---------------------|----------------------------------------------|  
|[!INCLUDE[pn_crm_8_2_0_online](../includes/pn-crm-8-2-0-online.md)] with [!INCLUDE[pn_Microsoft_Exchange_Online](../includes/pn-microsoft-exchange-online.md)]|-   Relationship assistant<br />-   Email engagement<br />-   Auto capture|  
|[!INCLUDE[pn_crm_8_2_0_online](../includes/pn-crm-8-2-0-online.md)] with [!INCLUDE[pn_Microsoft_Exchange](../includes/pn-microsoft-exchange.md)] (on-premises)|-   Relationship assistant (not including cards for [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)])<br />-   Email engagement|  
|[!INCLUDE[pn_crm_8_2_0_op_subsequent](../includes/pn-crm-8-2-0-op-subsequent.md)]|-   Only the relationship assistant is available, and only its *base cards* are supported. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Action cards reference](../admin/action-cards-reference.md)<br />-   No features or action cards are available for [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)], so your [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] version is not important.|  
  
 **Auto capture also requires the following:**  
  
-   You must use [!INCLUDE[pn_Microsoft_Exchange_Online](../includes/pn-microsoft-exchange-online.md)] as your email server. 
  
-   Users must use the web client for [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] (other front ends are not supported).  
  
-   For each user that requires access to this feature, you must approve their email address to allow queries against [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] (requires tenant-level admin privileges). [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Approve email](connect-exchange-online.md#approve-email) 
  
-   To track incoming email messages, you must set up server-side synchronization. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up server-side synchronization of email, appointments, contacts, and tasks](set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks.md)  
  
**Email engagement also requires the following:** 
  
-   To use followed email attachments, [!INCLUDE[pn_onedrive_for_business](../includes/pn-onedrive-for-business.md)] must be available to your [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Enable OneDrive for Business](enable-onedrive-for-business.md)  
  
-   To use followed email attachments, you must also enable document management for email in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Enable SharePoint document management for specific entities](../admin/enable-sharepoint-document-management-specific-entities.md)  
  
-   To enable delivery-time recommendations based on recipients' time zones, you must enable [!INCLUDE[pn_bing_maps](../includes/pn-bing-maps.md)] in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [System Settings dialog box - General tab](../admin/system-settings-dialog-box-general-tab.md)  

**Relationship analytics also requires the following:**

-  <!-- JimHoltz: get this list from Jason -->

  
<a name="UserRoles"></a>   

## Assign user privileges to give access to Relationship Assistant features  
 The privileges required to access Relationship Insights features are automatically enabled for all out-of-the-box security roles, but are initially disabled for all custom roles. If you enable *any* Relationship Insights features, then you must check the settings listed in the following table to ensure that your users can access those features, and also to ensure that other features don't stop working as a result of privilege cascades related to these features.  
  
|Privilege|Security role tab|Description and requirements|  
|---------------|-----------------------|----------------------------------|  
|**Action Card**|**Core Records**|Gives the ability to view and interact with action cards that are generated by the relationship assistant. **Warning:**  If the relationship assistant is enabled, then all users *must* have a role with read access for this privilege. Because of cascading, users without this privilege will lose access to many [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] features when the relationship assistant is enabled.|  
|**Action Card User Settings**|**Core Records**|Gives the ability to view and change user preferences for action cards that are generated by the relationship assistant. **Warning:**  If the relationship assistant is enabled, then all users *must* have a role with read access for this privilege. Because of cascading, users without this privilege will lose access to many [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] features when the relationship assistant is enabled.|  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Security roles and privileges](security-roles-privileges.md)  
  
<a name="RIsettings"></a>   

## Open the Relationship Insights settings to enable and configure its features  
 Administrator settings for all Relationship Insights features are available on  a single settings page, which provides a tab for each feature. To open the settings, go to **Settings** > **Relationship Insights**.  
  
 ![Relationship Insights option in Settings](../admin/media/navigate-relationship-insights-settings.png "Relationship Insights option in Settings")  
  
 If this is the first time you are using Relationship Insights, then you see a privacy disclaimer, legal terms, and other important information. Read the information and, if you agree with the terms, click to continue to the settings page. You only need to do this once; after that you'll go straight to the settings.  
  
> [!IMPORTANT]
>  Relationship Insights provides features that track behavior and collect information about contacts. Make sure you understand the related privacy issues that these features raise, and enable the features only if you are certain that they do not violate any privacy policies already in place in your organization. Always take steps to protect the privacy of your contacts. For complete details, see [Privacy notices](#privacy), later in this topic.  
  
<a name="ConfigAssistant"></a>   

## Activate and configure the relationship assistant  
 The relationship assistant is automatically enabled after you  opt in to the preview and accept the agreement on first opening the **Relationship Insights** settings. After this, you can disable and re-enable it at any time by doing the following:  
  
1.  Go to **Settings** > **Relationship Insights** to open the settings page, and then open the **Relationship Assistant** tab.  
 
   <!--  JimHoltz: update this with Relationship analytics -->
 
    ![Relationship assistant settings](../admin/media/relationship-assistant-settings.png "Relationship assistant settings")  
  
2.  Select the **Turn on the relationship assistant for your organization** check box at the top of the page to enable the relationship assistant on your site. Clear this box to disable the feature.  
  
    > [!IMPORTANT]
    >  By enabling this feature, you consent to share data about your customers' email activity with an external system. Data imported from external systems into [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] are subject to our privacy statement. For complete details, see [Privacy notices](#privacy), later in this topic.  
  
3.  The rest of the settings on this page let you configure which cards to use and fine tune their behavior. Work with the settings here as follows:  
  
    -   Cards are categorized by type, with a section for each type that you can expand or collapse as needed.  
  
    -   Enable or disable specific action cards as needed by using the check boxes provided for each card.  
  
    -   Some cards have extra configuration settings that modify their behavior. These settings are provided to the right of the check box for the relevant cards only.  
  
    -   If you're not sure what a card does, hover your mouse pointer over the preview symbol ![Action card preview button](../admin/media/action-card-preview-icon.png "Action card preview button") and a description of the card will pop up as a tool tip.  
  
     For complete details about each available action card, including details about the configuration settings available for each of them and other details, see [Action cards reference](../admin/action-cards-reference.md).  
  
4.  Click the **Save** button at the top of the page to save your settings.  
  
 For more information about the relationship assistant and how it can help your users, see [Relationship assistant](../admin/relationship-assistant.md).  
  
> [!NOTE]
>  Users can also set their own personal preferences for their action cards. They can't add cards that you disable here, but they can disable cards that you have enabled if they don't find them useful. They can also change the configuration settings for those cards that have them, though your settings will be the defaults. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Relationship assistant](../admin/relationship-assistant.md)  
  
<a name="ConfigEmailEngagement"></a>   
## Activate and configure email engagement  
  
> [!NOTE]
>  If you enable email engagement, then we strongly recommend that you also enable the relationship assistant, because email engagement relies on some of its features.  
  
 To configure, enable, or disable email engagement:  
  
1.  Go to **Settings** > **Relationship Insights** to open the settings page, and then open the **Email Engagement** tab.  
  
     If you've never enabled email engagement before, then the **Email Engagement** tab shows a checkbox next to a privacy disclaimer. Read the disclaimer carefully, and follow its links for complete details. If you agree with its terms, select the checkbox and then click the **Begin Setup** button to initialize the feature, which might take a few minutes. When setup is complete, the standard email engagement settings are shown. You only have to do this once.  
  
2.  Select the **Turn on email engagement for your organization** check box at the top of the page to enable email engagement on your site. Clear this box to disable the feature.  
  
    > [!IMPORTANT]
    >  By enabling this feature, you consent to share data about your customers' email activity with an external system. Data imported from external systems into [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] are subject to our privacy statement. For complete details, see [Privacy notices](#privacy), later in this topic.  
  
3.  Click the **Save** button at the top of the panel to save your settings.  
  
 For more information about email engagement and how this feature can help your users, see [Email engagement](../admin/email-engagement.md).  
  
<a name="ConfigAutoCapture"></a>   

## Activate and configure auto capture  
 Auto capture is automatically enabled after you opt in to the preview and accept the agreement on opening the **Relationship Insights** settings. You can disable and re-enable it at any time by doing the following:  
  
1.  Go to **Settings** > **Relationship Insights** to open the settings page, and then open the **Auto Capture** tab.  
  
2.  Select the **Enable auto capture in the organization** check box at the top of the page to enable email engagement on your site. Clear this box to disable the feature.  
  
    > [!IMPORTANT]
    >  By enabling this feature, you consent to share data about your customers' email activity with an external system. Data imported from external systems into [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] are subject to our privacy statement. For complete details, see [Privacy notices](#privacy), later in this topic.  
  
3.  Click the **Save** button at the top of the page to save your settings.  
  
 For more information about auto capture and how this feature can help your users, see [Auto capture](../admin/auto-capture.md).  
 
<a name="ConfigAnalytics"></a>   

## Activate and configure Relationship Analytics 
<!-- JimHoltz: add content from Jason's internal doc for private preview. -->
 
<a name="privacy"></a>   
## Privacy notices  
[!INCLUDE[cc_privacy_relationship_insights_relationship_assistant](../includes/cc-privacy-relationship-insights-relationship-assistant.md)]
  
[!INCLUDE[cc_privacy_relationship_insights_email_engagement](../includes/cc-privacy-relationship-insights-email-engagement.md)]
  
[!INCLUDE[cc_privacy_relationship_insights_auto_capture](../includes/cc-privacy-relationship-insights-auto-capture.md)]
  
