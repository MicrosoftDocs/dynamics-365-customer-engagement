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

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

<a name="Prerequisites"></a>   

## Requirements and prerequisites  
There are some feature restrictions depending on which versions of [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] and [!INCLUDE[pn_Microsoft_Exchange](../includes/pn-microsoft-exchange.md)] you are running, as detailed in the following table.  
  
|Product version|Available Embedded intelligence features|  
|---------------------|----------------------------------------------|  
|[!INCLUDE[pn_crm_8_2_0_online](../includes/pn-crm-8-2-0-online.md)] with [!INCLUDE[pn_Microsoft_Exchange_Online](../includes/pn-microsoft-exchange-online.md)]|-   Relationship assistant<br />-   Email engagement<br />-   Auto capture|  
|[!INCLUDE[pn_crm_8_2_0_online](../includes/pn-crm-8-2-0-online.md)] with [!INCLUDE[pn_Microsoft_Exchange](../includes/pn-microsoft-exchange.md)] (on-premises)|-   Relationship assistant (not including cards for [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)])<br />-   Email engagement|  
|[!INCLUDE[pn_crm_8_2_0_op_subsequent](../includes/pn-crm-8-2-0-op-subsequent.md)]|-   Only the relationship assistant is available, and only its *base cards* are supported. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Action cards reference](../admin/action-cards-reference.md)<br />-   No features or action cards are available for [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)], so your [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] version is not important.|  

## How to enable embedded intelligence 
As a  [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] administrator, you can enable embedded intelligence for your organization to:
- Enable and configure features such as Relationship assistant, Email engagement, and Auto capture  
- Install Sales insights add-on for preview 

> [!IMPORTANT]
> Embedded intelligence provides features that track behavior and collect information about contacts. Make sure you understand the related privacy issues that these features raise, and enable the features only if you are certain that they do not violate any privacy policies already in place in your organization. Always take steps to protect the privacy of your contacts. 

To enable the Embedded intelligence, follow these steps:

1. Go to **Settings** > **Intelligence Configuration**.<br>
![Select Intelligence configuration](../admin/media/intelligence-configuration-option.png "Select Intelligence configuration") <br>
2. Choose **I Accept** to accept privacy statement for **Embedded intelligence** in the **Overview tab**.<br>
![Accept privacy statement of Embedded intelligence](../admin/media/accept-privacy-statement-embedded-intelligence.png "Accept privacy statement of Embedded intelligence") <br>

Embedded intelligence is enabled for your organization and you can configure features such as Relationship Assistant, Email Engagement, and Auto Capture.

>[!NOTE]
> Once you accept privacy notes of all Embedded intelligence features, they are available on a single settings page, which provides a tab for each feature.

## Enable and configure relationship assistant

Configuring relationship assistant helps you to enable cards such as task due today, custom activity due today, and email due today to users in your organization. 
<!--  Also, you can enable notes analysis that helps users to take actions on highlighted text on cards. -->
> [!IMPORTANT]
> By enabling this feature, you consent to share data about your customers' email activity with an external system. Data imported from external systems into  [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] are subject to our privacy statement

For complete details about each available action card, including details about the configuration settings available for each of them and other details, see [Action cards reference](action-cards-reference.md)  

### Prerequisites
Assign user privileges to give access to relationship assistant features - The privileges required to access Embedded intelligence features are automatically enabled for all out-of-the-box security roles, but are initially disabled for all custom roles. If you enable any Embedded intelligence features, then you must check the settings listed in the following table to ensure that your users can access those features, and to ensure that other features don't stop working as a result of privilege cascades related to these features.

|Privilege|Security role tab|Description and requirements|  
|---------------|-----------------------|----------------------------------|  
|**Action Card**|**Core Records**|Gives the ability to view and interact with action cards that are generated by the relationship assistant. **Warning:**  If the relationship assistant is enabled, then all users *must* have a role with read access for this privilege. Because of cascading, users without this privilege will lose access to many [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] features when the relationship assistant is enabled.|  
|**Action Card User Settings**|**Core Records**|Gives the ability to view and change user preferences for action cards that are generated by the relationship assistant. **Warning:**  If the relationship assistant is enabled, then all users *must* have a role with read access for this privilege. Because of cascading, users without this privilege will lose access to many [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] features when the relationship assistant is enabled.|  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Security roles and privileges](security-roles-privileges.md)  

### How to configure relationship assistant

1.	Go to **Settings** > **Intelligence Configuration**.
2.  Choose **Configuration** on the **Relationship assistant** tile or select **Relationship assistant** tab to open **Relationship assistant** configuration page.<br>
![Select Relationship assistant configuration](../admin/media/relationship-assistant-configuration.png "Select Relationship assistant configuration") <br>    
3.	Configure which cards to use in your organization and fine tune their behavior. Work with the settings here as follows:
    - Cards are categorized by type such as Base and Advanced.
    - Enable or disable specific action cards as needed by using the check boxes provided for each card.
    - Some cards have extra configuration settings that modify their behavior. These settings are provided to the right of the check box for the relevant cards only.<br>
![Relationship assistant configuration page](../admin/media/relationship-assistant-configuration-page.png "Relationship assistant configuration page") <br>
<!--4.	To enable notes analysis, select **Turn on Notes Analysis for your organization** check box under **Notes Analysis** tile.
<<add image>>   -->
4.	Select **Save** on the top of the page to save your settings.<br> 

Users can also set their own personal preferences for their action cards. They can't add cards that you disable here, but they can disable cards that you have enabled if they don't find them useful. They can also change the configuration settings for those cards that have them, though your settings will be the defaults. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Relationship assistant](../admin/relationship-assistant.md)

## Enable email engagement
Enabling the email engagement helps the user in your organization to receive alerts and remainders which help in building customer relationships.
> [!NOTE]
> If you enable email engagement, then we strongly recommend that you also enable the relationship assistant, because email engagement relies on some of its features.

> [!IMPORTANT]
> By enabling this feature, you consent to share data about your customers' email activity with an external system. Data imported from external systems into  [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] are subject to our privacy statement.

### Prerequisites
Verify the following prerequisites before enabling email engagement for your organization:
- To use followed email attachments, [!INCLUDE[pn_onedrive_for_business](../includes/pn-onedrive-for-business.md)] must be available to your [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Enable OneDrive for Business](enable-onedrive-for-business.md)  
- To use followed email attachments, you must also enable document management for email in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Enable SharePoint document management for specific entities](../admin/enable-sharepoint-document-management-specific-entities.md)  
- To enable delivery-time recommendations based on recipients' time zones, you must enable [!INCLUDE[pn_bing_maps](../includes/pn-bing-maps.md)] in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [System Settings dialog box - General tab](../admin/system-settings-dialog-box-general-tab.md)  

### How to enable email engagement

1.	Go to **Settings** > **Intelligence Configuration**.
2.	Select **Grant Permissions**. <br>
    > [!NOTE]
    > If Sales insights add-on is installed using Intelligence Configuration, you need not grant permissions to Email engagement and this step will be skipped.<br>

    Email engagement is enabled and ready to use in your organization. <br>

    > [!NOTE]
    > To enable or disable **Email engagement**, use **Enable** toggle button.<br>
    >  ![Enable or disable Email engagement](../admin/media/email-engagement-enable-disable.png "Enable or disable Email engagement") 

## Enable auto capture

Enabling the auto capture helps the user in your organization to automatically add relative activities of their customers to [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)].

> [!IMPORTANT]
> By enabling this feature, you consent to share data about your customers' email activity with an external system. Data imported from external systems into  [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] are subject to our privacy statement.

### Prerequisites

Verify the following prerequisites before enabling auto capture for your organization: 
-   You must use [!INCLUDE[pn_Microsoft_Exchange_Online](../includes/pn-microsoft-exchange-online.md)] as your email server. 
-   Users must use the web client for [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] (other front ends are not supported).  
-   For each user that requires access to this feature, you must approve their email address to allow queries against [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] (requires tenant-level admin privileges). [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Approve email](connect-exchange-online.md#approve-email) 
-   To track incoming email messages, you must set up server-side synchronization. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up server-side synchronization of email, appointments, contacts, and tasks](set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks.md)  

### How to enable auto capture
When you accept the privacy statement for **Embedded intelligence**, Auto capture feature is enabled by default. If not enabled, select the toggle button to enable Auto capture.<br>
![Enable or disable Auto capture](../admin/media/auto-capture-enable-disable.png "Enable or disable Auto capture")

>[!NOTE]
> For more information about auto capture and how this feature can help your users, see [Auto capture](../admin/auto-capture.md)

## Preview feature: Install and configure Sales insights add-on
<!--remove comment tags when the predictive lead scoring is going live.-->

The Sales insights add-on contains relationship analytics <!--and predictive lead scoring -->feature. <!--These--> This feature not available by default. You need to install Sales insights add-on to use this feature. <br>
> [!NOTE]
> To install this feature, you must be a Dynamics 365 administrator.

To understand how relationship analytics is used<!--and predictive lead scoring works-->, see [Relationship analytics](../admin/relationship-analytics.md)

The following process defines the steps to install and configure relationship analytics<!-- and lead scoring-->.
1.	Install Sales insights add-on.
2.	Configure relationship analytics.
3.  (Optional) Uninstall Sales insights add-on.

### Install Sales insights add-on 
1.	Go to **Settings** > **Embedded intelligence**.<br>
     ![Embedded intelligence home screen](../admin/media/install-sales-insights-addon.png "Embedded intelligence home screen")  
     <br>

    > [!NOTE]
    > If you are using Embedded Intelligence for the first time, enable the features. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [How to enable embedded intelligence](#How-to-enable-embedded-intelligence).


2.  Choose **Install** from **Sales insights add-on** tile. <br>
    ![Sales insights addon tile](../admin/media/install-sales-insights-addon-tile.png "Sales insights addon tile")  
     <br>
3.	Carefully read and select the terms and conditions. Choose **Continue**, on the **Sales Insights** installation page. <br>
    The installation takes few minutes to complete and the status is displayed in the status bar.<br>
    ![Accept sales insights addon terms and conditions](../admin/media/sales-insights-addon-terms-conditions.png "Accept sales insights addon terms and conditions") <br>
    Now, you are ready to configure Relationship analytics<!-- and Predictive Lead Scoring-->.

### Configure Sales insights add-on

Once the sales insights add-on is installed, proceed through the steps below to configure Relationship analytics <!-- and predictive lead scoring --> according to the requirements of your organization.

1.	Choose **Go to Configuration** on the installation page of Sales Insights.

    > [!NOTE]
    > you can also select **Configuration** in the Relationship analytics <!-- or Predective lead scoring--> tile, on the Embedded intellilgence **Overview** tab. This option will be available only after you install the sales insights add-on.    
    ![Relationship analytics configuration](../admin/media/relationship-analytics-configuration.png "Relationship analytics configuration") <br>
     <!--Have to change the screen once Predective lead scoring is available-->
    The relationship analytics configuring page opens.
2.  Read and accept the Relationship analytics terms and conditions and select **Begin Setup**. <br>
    ![Accept terms and conditions for Relationship analytics](../admin/media/relationship-analytics-terms-conditions.png "Accept terms and conditions for Relationship analytics") <br>
3.	Configure<!-- predictive lead scoring and--> relationship analytics as specified in the following steps.<br>
    a. On the **Relationship analytics** page, configure the parameters as described in the following table.

    |**Parameter**|**Description**|  
    |---------------------|----------------------------------------------|  
    |Data Sources|**CRM Activities:** All historical data from Dynamics 365 will be ingested for computation in Relationship Analytics.<br>**Exchange Data:** If Exchange data is enabled, 30 days of data from Exchange will be ingested for KPI and Health computation. Exchange connector will ingest three days of data per day until the last 30 days of data has been completed.|  
    |Relationship Health Score|Businesses place different emphasis on the type of communication used with customers. You can modify the importance of activities of different types as they contribute to the relationship health score.|  
    |Communications Frequency|Businesses have varying sales cycles and as a result, a different expected level of communications with the customer.  A longer expected communications frequency will reduce the expectation of more recent frequent communications in the health score.  A shorter expected communications frequency will increase the expectation of more recent frequent communications in the health score.|<br>
       
    ![Relationship analytics configuration settings page](../admin/media/relationship-analytics-configuration-settings.png "Relationship analytics configuration settings page") <br>
    b. Select **Save**.<br>
       The relationship analytics is configured and ready to use in your organization.
<br>

### (Optional) Uninstall Sales insights add-on

If you do not want to use Sales insights add-on for your organization, uninstall the feature.
1.	Go to **Settings** > **Customization** > **Solutions**.
    A list of solutions that are install in your organization is displayed.
2. Select **SalesInsightsAddOn** and then select Delete.<br>
   ![Sales insights add-on delete](../admin/media/sales-insights-addon-uninstall.png "Sales insights add-on delete") <br>
3. A confirmation message is displayed. Select **OK**.<br>
   The Sales insighs add-on feature is uninstalled from your organization. 
