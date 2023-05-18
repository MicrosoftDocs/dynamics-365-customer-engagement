---
title: Enable and configure Sales Insights
description: Learn about how to enable and configure Sales Insights capabilities in your organization.
ms.date: 09/08/2022
ms.custom: intro-internal
ms.topic: article
author: udaykirang
ms.author: udag
caps.latest.revision: 1
topic-status: Drafting
---
# Enable and configure Sales Insights features 

Enabling and configuring the [!INCLUDE[pn-dynamics-sales-insights](../includes/pn-dynamics-sales-insights.md)] features helps sellers to build stronger relationships with their customers, save time, and stay on top of their deals with real-time AI-based insights. In Sales Insights, some features are available for free along with Dynamics 365 Sales and some require an additional Sales Insights license to use in your organization. More information: [Overview](overview.md) 

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise and Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## What you can configure

As an administrator, you can enable and configure the Sales Insights features as required in your organization:

-    [Enable and configure standard Sales Insights features](#enable-and-configure-standard-sales-insights-features)
-   [Get started with premium Sales Insights features](#get-started-with-premium-sales-insights-features)
-    [Install and configure premium Sales Insights features](#install-and-configure-premium-sales-insights-features)   
-    [Administer conversation intelligence](#administer-conversation-intelligence)

## Enable and configure standard Sales Insights features

The standard Sales Insights features&mdash;assistant (standard), Auto capture (standard), and email engagement (standard)&mdash;are available for you along with Dynamics 365 Sales. You can configure these standard features as required in your organization.

>[!NOTE]
>The standard Sales Insights features aren't available with the Sales Professional app. 

1.	[Review requirements and prerequisites](#requirements-and-prerequisites).  
2.	[Enable standard Sales Insights features](#enable-standard-sales-insights-features).    
3.	[Configure standard features as required](#configure-standard-sales-insights-features).

### Requirements and prerequisites

Review the following requirements and prerequisites to enable standard Sales Insights features:

- Some feature restrictions apply depending on which combinations of Dynamics 365 and Exchange you're running, as detailed in the following table.

    | Product version | Available standard Sales Insights features |
    |-----------------|--------------------------------------------|    
    | Dynamics 365 with Microsoft Exchange Online | <ul><li>Assistant (standard cards)</li> <li>Email engagement</li> <li>Auto capture</li></ul>|
    | Dynamics 365 with Microsoft Exchange (on-premises) | <ul><li>Assistant (all cards except cards based on Exchange information)</li> <li>Email engagement</li></ul>|
    | Dynamics 365 (on-premises) | Assistant (standard cards) |
    | Dynamics 365 (on-premises) with Microsoft Exchange Online | Assistant (standard cards) |

- The assistant, email engagement, and auto capture features are available for Dynamics 365 Sales with an Enterprise or Sales Premium license.

### Enable standard Sales Insights features

Before you can configure these features, you must accept the privacy notice. To accept the privacy notice, follow the steps listed here.

>[!NOTE]
>By default, the standard assistant is enabled.

> [!IMPORTANT]
> [!INCLUDE[pn-dynamics-sales-insights](../includes/pn-dynamics-sales-insights.md)] provides features that track behavior and collect information about contacts. Make sure you understand the related privacy issues that these features raise and enable the features only if you're certain that they don't violate any privacy policies already in place in your organization. Always take steps to protect the privacy of your contacts. More information: [Privacy notice](privacy-notice.md)

1. Sign in to Dynamics 365 Sales, and go to the Sales Hub app.

2. Go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.
   :::image type="content" source="media/si-admin-change-area-sales-insights-settings.png" alt-text="Select Sales Insights settings"::: 
 
3. In the **Terms of service** section, select **I agree**.
    :::image type="content" source="media/si-admin-accept-privacy-notice.png" alt-text="Agree to the terms of service":::

    The standard Sales Insights features are enabled for your organization and you can configure features such as the standard assistant, auto capture (standard), and email engagement (standard).

    :::image type="content" source="media/si-admin-free-features-enabled.png" alt-text="Standard Sales Insights features enabled":::


### Configure standard Sales Insights features

After you enable the standard Sales Insights features, you can configure the features for your organization.

-    To configure the standard assistant, see [Configure and manage insight cards for the standard assistant](configure-assistant.md#configure-and-manage-insight-cards-for-the-standard-assistant).   
-    To configure standard auto capture, see [Configure and enable auto capture](configure-auto-capture.md).    
-    To configure standard email engagement, see [Configure and enable email engagement](configure-email-engagement.md).   
-    To Configure sales accelerator for assignment rules, see [Configure assignment rules in Sales Enterprise](sales-accelerator-assignment-rules.md)

## Get started with premium Sales Insights features

With your Dynamics 365 Sales Enterprise license, you can set up and experience Sales Premium features such as Sales accelerator, conversation intelligence, and predictive scoring with a limited monthly capacity. More information: [Digital selling capabilities in Sales Enterprise](digital-selling.md)

## Enable and configure premium Sales Insights features

The premium Sales Insights features provide intelligent insights about sales data that help sellers take timely actions to close deals and generate revenue. The premium Sales Insights features include the premium assistant with assistant studio, notes analysis, relationship analytics, who knows whom, predictive lead scoring, predictive opportunity scoring, premium forecasting, and sales accelerator and sequence. You can configure these features as required in your organization.

1.    [Review privacy and personal data requirements](#review-privacy-and-personal-data-requirements).   
2.    [Review the prerequisites](#review-the-prerequisites).   
3.    [Install premium Sales Insights](#install-premium-sales-insights).   
4.    [Configure premium Sales Insights features](#configure-premium-sales-insights-features).

### Review privacy and personal data requirements

To learn about requirements related to safeguarding customers' privacy and personal data, go to [Privacy and personal data for Microsoft Dynamics 365](/dynamics365/get-started/gdpr).

You can perform the following tasks in the auto capture, relationship analytics, and conversation intelligence features to ensure that you are complying with privacy and personal data requirements.

|Task|Supported Feature|Topic|
|--|--|--|
|View KPI data stored for a contact, lead, and opportunity by using system views, and export it to Excel.|[Relationship Analytics](relationship-analytics.md)|[View and export KPI data (GDPR)](view-export-KPI-data-gdpr.md)|
|Retrieve data for an contact, lead, opportunity, and system user from Azure service that is used to compute and store data by using a custom action.|[Relationship Analytics](relationship-analytics.md) and [Introduction to Conversation Intelligence](../sales/dynamics365-sales-insights-app.md)|[Retrieve insights data using msdyn_RetrieveKPIValuesForGDPR action (GDPR)](retrieve-insights-data-msdyn-RetrieveTypeValuesFromDCI.md)  |

### Review the prerequisites

Review the following requirements before you install and configure the premium Sales Insights features:

- You must be a Dynamics 365 Sales administrator.  
- You must have a Sales Premium, Sales Insights, or a Sales Enterprise license.    
    > [!NOTE]
    > - You can also start a free trial to use the sales premium features. More information: [Sign up for a free Dynamics 365 Sales trial](/dynamics365/sales-enterprise/sign-up-for-sales-trial)
    > - If you have a Dynamics 365 Sales Enterprise license, you can install and configure three premium features (Sales accelerator, conversation intelligence, and predictive scoring) with a limited monthly capacity. More information: [Digital selling capabilities in Sales Enterprise](digital-selling.md)

- Assign licenses to each individual user to utilize the features. This is executed within the [Microsoft 365 admin center](https://admin.microsoft.com/Adminportal/Home?#/homepage). More information: [Assign licenses to users](/microsoft-365/admin/manage/assign-licenses-to-users?view=o365-worldwide&preserve-view=true).     
- Exchange email server is configured, and a mailbox is enabled using **Email Configurations** in **Settings**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [System Settings dialog box - Email tab](/dynamics365/customer-engagement/admin/system-settings-dialog-box-email-tab).

### Enable premium Sales Insights

> [!NOTE]
> To install and configure three premium features (Sales accelerator, conversation intelligence, and predictive scoring) that are available with the Sales Enterprise license, you must go to the **Get started with digital sales page** under **App Settings**. More information: [Digital selling capabilities in Sales Enterprise](digital-selling.md)

The premium Sales Insights features aren't available by default. You must install these features by accepting the terms and conditions for your organization. To accept the terms and conditions, follow these steps:

1. Sign in to Dynamics 365 Sales, and go to the Sales Hub app.

2. Go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.

    > [!div class="mx-imgBorder"]
    > ![Select Sales Insights settings](media/si-admin-change-area-sales-insights-settings.png "Select Sales Insights settings")
 
3. In the **Supercharge your sales with Premium** section, select the terms and conditions and then select **Get started**.

    > [!div class="mx-imgBorder"]
    > ![Select Try Sales Insights](media/si-admin-select-try-sales-insights.png "Select Try Sales Insights")
 
    The installation may takes a few minutes to complete, and the progress is displayed in a dialog. After the installation is complete, you're ready to configure the premium Sales Insights features.

    > [!div class="mx-imgBorder"]
    > ![Premium Sales Insights settings page](media/si-admin-advanced-installation-complete.png "Premium Sales Insights settings page")
 
### Configure premium Sales Insights features

After installing the premium Sales Insights features, you can configure the premium features as required:

-    To configure the premium assistant, see [Configure and manage insight cards for the premium assistant](configure-assistant.md#configure-and-manage-insight-cards-for-the-premium-assistant).   
 
-    To configure notes analysis, see [Configure notes analysis](configure-notes-analysis.md).   
-    To configure relationship analytics, see [Configure Relationship analytics](configure-relationship-analytics.md).   
-    To configure who knows whom, see [Configure who knows whom](configure-who-knows-whom.md).   
-    To configure predictive lead scoring, see [Configure predictive lead scoring](configure-predictive-lead-scoring.md).   
-    To configure predictive opportunity scoring, see [Configure predictive opportunity scoring](configure-predictive-opportunity-scoring.md).    
-   To configure premium forecasting, see [About premium forecasting](configure-premium-forecasting.md).    
-   To configure sales accelerator and sequence (preview), see [Enable and configure sales accelerator](enable-configure-sales-accelerator.md).

## Administer conversation intelligence

Conversation intelligence assists the sales managers and sellers in your organization to get an overview of the conversation with customers. Conversation Intelligence helps:

-    Sales managers drill down to get call statistics for individual sellers, such as customer sentiment, keywords used, and competitors mentioned in the conversation. Sales managers can use this data to give smarter coaching to sellers and improve the business.  
-    Sellers analyze their conversation data and identify improvements in the conversation style to enhance sales and generate revenue. 

As an administrator, when you sign in to the application for the first time, you can set up the application. After you complete the setup, sales managers and sellers in your organization can sign in and use the application seamlessly. More information: [First-run setup experience of Sales Insight application](fre-setup-sales-insight-app.md)

You can also update each setting later as required. The following configurations are available:

-    Connect your Sales environment to gather data and display on KPIs. More information: [Connect conversation intelligence to an environment](connect-dynamics365-sales-environment.md)    
-    Connect to call data repository. More information: [Configure conversation intelligence to connect call data](configure-conversation-intelligence-call-data.md)   
-    Define keywords and competitors that will be tracked in conversations. More information: [Configure keywords and competitors to track](configure-keywords-competitors.md)   
-    Define how long you want to retain the data in the application, and remove seller-specific data. More information: [Data retention and deletion through Privacy](data-retention-deletion-policy.md)   
-    Enable preview features. More information: [Enable preview features](enable-preview-features-sales-insights-app.md)

## For effective use of Sales Insights

- Use the out-of-the-box entities (Contact, Opportunity, Lead, Account, and Case) while creating records in the application. If changes to the entity are required in your organization, customize only these out-of-the-box entities to meet your requirements. This helps the application to analyze the records, and generate models and predictions effectively.

- Ensure that the **Change Tracking** option for the following entities are enabled: Account, Contact, Lead, Opportunity, System User, Team, Queue, Organization, Email, Phone Call, Task, Appointment, Activity Party, Connection, Business Unit, Metric, Opportunity Product, Product, Opportunity Sales Process, Process Stage, Connection Role, Workflow, Goal, Role, System User Roles, Note, Auto Capture Settings, Auto Capture Rule, and Lead To Opportunity Sales Process.

    1. Go to **Settings** > **Customizations** > **Customize the System**.    
    2. On the **Default Solution** page, expand **Entity**, and then select an entity.   
    3. On the **General** tab, under **Data Services**, verify that the **Change Tracking** option is enabled.

- Ensure that you do not delete the **Sales Insights MDL Config** solution from the solutions. If this solution is deleted, the Sales Insights features give inaccurate results and might be disabled. 

    However, if you want to delete the **Sales Insights MDL Config** solution due to storage issues, uninstall the **SalesInsightsAddOn** solution too. This ensures that the **Sales Insights MDL Config** solution won't be automatically reinstalled when future updates are pushed to your organization.

## Privacy notice

For specific privacy information about Dynamics 365 Sales Insights capabilities, see [Privacy notice](privacy-notice.md).

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Overview of Dynamics 365 Sales Insights](overview.md)  
[Improve seller coaching and sales potential with Dynamics 365 Conversation Intelligence](../sales/dynamics365-sales-insights-app.md)  
[Sales Insights privacy notice](privacy-notice.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
