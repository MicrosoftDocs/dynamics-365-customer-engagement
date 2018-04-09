---
title: "Configure and enable embedded intelligence features for Dynamics 365 Customer Engagement  | MicrosoftDocs"
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
# Configure and enable embedded intelligence

Applies to Dynamics 365 (online), version 9.0.2

<a name="Prerequisites"></a>   

## Requirements and prerequisites  
There are some feature restrictions depending on which versions of [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] and [!INCLUDE[pn_Microsoft_Exchange](../includes/pn-microsoft-exchange.md)] you're running, as detailed in the following table.  
  
|Product version|Available embedded intelligence features|  
|---------------------|----------------------------------------------|  
|[!INCLUDE[pn_crm_8_2_0_online](../includes/pn-crm-8-2-0-online.md)] with [!INCLUDE[pn_Microsoft_Exchange_Online](../includes/pn-microsoft-exchange-online.md)]|<ul><li>Relationship assistant</li> <li>Email engagement</li> <li>Auto capture</li></ul>|  
|[!INCLUDE[pn_crm_8_2_0_online](../includes/pn-crm-8-2-0-online.md)] with [!INCLUDE[pn_Microsoft_Exchange](../includes/pn-microsoft-exchange.md)] (on-premises)|<ul><li>Relationship assistant (not including cards for [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)])</li> <li>Email engagement</li></ul>|  
|[!INCLUDE[pn_crm_8_2_0_op_subsequent](../includes/pn-crm-8-2-0-op-subsequent.md)]|<ul><li>Only Relationship assistant is available, and only its *base cards* are supported. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Action cards reference](../admin/action-cards-reference.md)</li> <li>No features or action cards are available for [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)], so your [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] version isn't important.</li></ul>|  

## How to enable embedded intelligence 
As a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] administrator, you can enable embedded intelligence for your organization to:
- Enable and configure features such as Relationship assistant, Email engagement, and Auto capture.  
- Install Sales insights add-on for preview. 

> [!IMPORTANT]
> Embedded intelligence provides features that track behavior and collect information about contacts. Make sure you understand the related privacy issues that these features raise and enable the features only if you're certain that they don't violate any privacy policies already in place in your organization. Always take steps to protect the privacy of your contacts. 

To enable the embedded intelligence:

1. Go to **Settings** > **Intelligence Configuration**.<br>
![Select Intelligence configuration](../admin/media/intelligence-configuration-option.png "Select Intelligence configuration") <br>
2. On the **Overview** tab, select **I Accept** to accept the privacy statement for **Embedded intelligence**.<br>
![Accept privacy statement of Embedded intelligence](../admin/media/accept-privacy-statement-embedded-intelligence.png "Accept privacy statement of Embedded intelligence") <br>

Embedded intelligence is enabled for your organization and you can configure features such as Relationship assistant, Email engagement, and Auto capture.

>[!NOTE]
> After you accept privacy notes of all embedded intelligence features, they're available on a single settings page, which provides a tab for each feature.

## Enable and configure Relationship assistant

To enable cards such as task due today, custom activity due today, and email due today to users in your organization, you can configure Relationship assistant. 
<!--  Also, you can enable notes analysis that helps users to take actions on highlighted text on cards. -->
> [!IMPORTANT]
> By enabling this feature, you consent to share data about your customers' email activity with an external system. Data imported from external systems into [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] are subject to our privacy statement.

For complete details about each available action card, including details about the configuration settings available for each of them and other details, see [Action cards reference](action-cards-reference.md).  

### Prerequisites
Assign user privileges to give access to the Relationship assistant features. The privileges required to access embedded intelligence features are automatically enabled for all out-of-the-box security roles, but they're initially disabled for all custom roles. If you enable any embedded intelligence features, you must check the settings listed in the following table to help ensure that your users can access those features, and to help ensure that other features don't stop working because of privilege cascades related to these features.

|Privilege|Security role tab|Description and requirements|  
|---------------|-----------------------|----------------------------------|  
|**Action Card**|**Core Records**|Gives the ability to view and interact with action cards that are generated by Relationship assistant. **Warning:** If Relationship assistant is enabled, all users *must* have a role with read access for this privilege. Because of cascading, users without this privilege will lose access to many [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] features when Relationship assistant is enabled.|  
|**Action Card User Settings**|**Core Records**|Gives the ability to view and change user preferences for action cards that are generated by Relationship assistant. **Warning:** If Relationship assistant is enabled, all users *must* have a role with read access for this privilege. Because of cascading, users without this privilege will lose access to many [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] features when Relationship assistant is enabled.|  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Security roles and privileges](security-roles-privileges.md)  

### How to configure Relationship assistant

1.	Go to **Settings** > **Intelligence Configuration**.
2.  To open the Relationship assistant configuration page, select **Configure** on the **Relationship assistant** tile or select the **Relationship assistant** tab.<br>
![Select Relationship assistant configuration](../admin/media/relationship-assistant-configuration.png "Select Relationship assistant configuration") <br>    
3.	Configure which cards to use in your organization and fine tune their behavior. Work with these settings as follows:
    - Cards are categorized by type, such as **Base** and **Advanced**.
    - Enable or disable specific action cards as needed by using the check boxes provided for each card.
    - Some cards have extra configuration settings that modify their behavior. These settings are provided to the right of the check box for only the relevant cards.<br>
![Relationship assistant configuration page](../admin/media/relationship-assistant-configuration-page.png "Relationship assistant configuration page") <br>
<!--4.	To enable notes analysis, select **Turn on Notes Analysis for your organization** check box under **Notes Analysis** tile.
<<add image>>   -->
4.	On top of the page, select **Save** to save your settings.<br> 

Users can also set their own personal preferences for their action cards. They can't add cards that you disable here, but they can disable cards that you have enabled if they don't find them useful. They can also change the configuration settings for those cards that have them, though your settings will be the defaults. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Relationship assistant](../admin/relationship-assistant.md)

## Enable Email engagement
Enabling the Email engagement helps the user in your organization to receive alerts and reminders that help build customer relationships.
> [!NOTE]
> If you enable Email engagement, we strongly recommend that you also enable Relationship assistant, because Email engagement relies on some of its features.

> [!IMPORTANT]
> By enabling this feature, you consent to share data about your customers' email activity with an external system. Data imported from external systems into  [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] are subject to our privacy statement.

### Prerequisites
Verify the following prerequisites before enabling Email engagement for your organization:
- To use followed email attachments, [!INCLUDE[pn_onedrive_for_business](../includes/pn-onedrive-for-business.md)] must be available to your [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Enable OneDrive for Business](enable-onedrive-for-business.md)  
- To use followed email attachments, you must also enable document management for email in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Enable SharePoint document management for specific entities](../admin/enable-sharepoint-document-management-specific-entities.md)  
- To enable delivery-time recommendations based on recipients' time zones, you must enable [!INCLUDE[pn_bing_maps](../includes/pn-bing-maps.md)] in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [System Settings dialog box - General tab](../admin/system-settings-dialog-box-general-tab.md)  

### How to enable Email engagement

1.	Go to **Settings** > **Intelligence Configuration**.
2.	Select **Grant Permissions**. <br>
    > [!NOTE]
    > If the Sales insights add-on is installed using Intelligence Configuration, this step will be skipped. You don't have to grant permissions to Email engagement.<br>

    Email engagement is enabled and ready to use in your organization. <br>

    > [!NOTE]
    > To enable or disable **Email engagement**, use the **Enable** toggle key.<br>
    >  ![Enable or disable Email engagement](../admin/media/email-engagement-enable-disable.png "Enable or disable Email engagement") 

## Enable Auto capture

 To help users in your organization to automatically add relative activities of their customers to [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], enable Auto capture.

> [!IMPORTANT]
> By enabling this feature, you consent to share data about your customers' email activity with an external system. Data imported from external systems into  [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] are subject to our privacy statement.

### Prerequisites

Verify the following prerequisites before enabling Auto capture for your organization: 
-   You must use [!INCLUDE[pn_Microsoft_Exchange_Online](../includes/pn-microsoft-exchange-online.md)] as your email server. 
-   Users must use the web client for [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] (other front ends aren't supported).  
-   For each user that requires access to this feature, you must approve their email address to allow queries against [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] (requires tenant-level admin privileges). [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Approve email](connect-exchange-online.md#approve-email) 
-   To track incoming email messages, you must set up server-side synchronization. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up server-side synchronization of email, appointments, contacts, and tasks](set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks.md)  

### How to enable Auto capture
After you accept the privacy statement for embedded intelligence, Auto capture is enabled by default. If it's not enabled, select the toggle button to enable Auto capture.<br>
![Enable or disable Auto capture](../admin/media/auto-capture-enable-disable.png "Enable or disable Auto capture")

>[!NOTE]
> For more information about Auto capture and how it can help your users, see [Auto capture](../admin/auto-capture.md)

## Preview feature: Install and configure the Sales insights add-on
<!--remove comment tags when the predictive lead scoring is going live.-->

The Sales insights add-on contains a Relationship analytics <!--and predictive lead scoring -->feature. <!--These--> This feature isn't available by default. To use this feature, you You need to install the Sales insights add-on. <br>
> [!NOTE]
> To install this feature, you must be a Dynamics 365 administrator.

To understand how Relationship analytics is used<!--and predictive lead scoring works-->, see [Relationship analytics](../admin/relationship-analytics.md).

To install and configure Relationship analytics<!-- and lead scoring-->:
1.	Install the Sales insights add-on.
2.	Configure Relationship analytics.
3.  (Optional) Uninstall the Sales insights add-on.

### Install the Sales insights add-on 
1.	Go to **Settings** > **Intelligence Configuration**.<br>
     ![Embedded intelligence home screen](../admin/media/install-sales-insights-addon.png "Embedded intelligence home screen")  
     <br>

    > [!NOTE]
    > If you're using embedded intelligence for the first time, enable the features. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [How to enable embedded intelligence](#How-to-enable-embedded-intelligence).


2.  On the **Sales insights add-on** tile, select **Install**. <br>
    ![Sales insights addon tile](../admin/media/install-sales-insights-addon-tile.png "Sales insights addon tile")  
     <br>
3.	On the **Sales Insights** installation page, carefully read and select the terms and conditions, and then select **Continue**. <br>
    The installation takes a few minutes to complete, and then the status appears in the status bar.<br>
    ![Accept sales insights addon terms and conditions](../admin/media/sales-insights-addon-terms-conditions.png "Accept sales insights addon terms and conditions") <br>
Now you're ready to configure Relationship analytics<!-- and Predictive Lead Scoring-->.

### Configure the Sales insights add-on

After you install the Sales insights add-on, perform the following steps to configure Relationship analytics <!-- and predictive lead scoring --> according to the requirements of your organization.

1.	On the **Sales insights add-on** installation page, select **Go to Configuration**.

    > [!NOTE]
    > You can also select **Configuration** on the **Relationship analytics** <!-- or Predective lead scoring--> tile, which is on the embedded intelligence **Overview** tab. This option is available only after you install the Sales insights add-on.    
    ![Relationship analytics configuration](../admin/media/relationship-analytics-configuration.png "Relationship analytics configuration") <br>
     <!--Have to change the screen once Predective lead scoring is available-->
    The **Relationship analytics** configuration page opens.
2.  Read and accept the Relationship analytics terms and conditions, and then select **Begin Setup**. <br>
    ![Accept terms and conditions for Relationship analytics](../admin/media/relationship-analytics-terms-conditions.png "Accept terms and conditions for Relationship analytics") <br>
3.	To configure<!-- predictive lead scoring and--> Relationship analytics, perform the following steps:<br>
    a. On the **Relationship analytics** page, configure the parameters as described in the following table.

    |**Parameter**|**Description**|  
    |---------------------|----------------------------------------------|  
    |Data Sources|**CRM Activities:** If enabled, all historical data from Dynamics 365 is ingested for computation in Relationship analytics.<br>**Exchange Data:** If enabled, 30 days of data from Exchange is ingested for KPI and health computation. Exchange connector ingests three days of data per day until the last 30 days of data is complete.|  
    |Relationship Health Score|Businesses place different emphasis on the type of communication used with customers. You can modify the importance of activities of different types as they contribute to the relationship health score.|  
    |Communications Frequency|Businesses have varying sales cycles and different expected levels of communications with customers. A longer expected communications frequency reduces the expectation of more recent frequent communications in the health score. A shorter expected communications frequency increases the expectation of more recent frequent communications in the health score.|<br>
       
    ![Relationship analytics configuration settings page](../admin/media/relationship-analytics-configuration-settings.png "Relationship analytics configuration settings page") <br>
    b. Select **Save**.<br>
       Relationship analytics is configured and ready to use in your organization.
<br>

### (Optional) Uninstall the Sales insights add-on

If you don't want to use the Sales insights add-on for your organization, you can uninstall it. To uninstall this feature:
1.	Go to **Settings** > **Customization** > **Solutions**.
    A list of solutions that are installed in your organization is displayed.
2. Select **SalesInsightsAddOn**, and then select **Delete**.<br>
   ![Sales insights add-on delete](../admin/media/sales-insights-addon-uninstall.png "Sales insights add-on delete") <br>
3. A confirmation message is displayed. Select **OK**.<br>
   The Sales insights add-on feature is uninstalled from your organization. 
