---
title: "Configure to view Intraday insights dashboard | MicrosoftDocs"
description: "Instructions to configure intraday insights dashboard for Unified Service Desk and Omnichannel for Customer Service."
keywords: ""
author: udaykirang
ms.author: udag
manager: shujoshi
applies_to: 
ms.date: 6/20/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: e8d3d8ae-3e5a-46a7-aed9-b7ad6f42a98f
ms.custom: 
---

# Configuring Dynamics 365 omnichannel insights dashboard

Customer service managers or supervisors are responsible for managing the agents who work to resolve customer queries every day through various service channels, including Chat. They need to be able to know key operational metrics to ensure that their agents are providing quality support. 

As an administrator, you must configure the configure the historical chat and sentiment insights dashboards to display in Omnichannel Engagement Hub app for supervisors to use. You must perform the following steps to configure the historical chat and sentiment insights dashboards: 

1.	[Step 1: Review the prerequisites](#step-1-review-the-prerequisites)
2.	[Step 2: Install Dynamics 365 Omnichannel Historical Chat Analytics app](#step-2-install-dynamics-365-omnichannel-historical-chat-analytics-app)
3.	[Step 3: Connect Dynamics 365 organization to Omnichannel Chat Insights app](#step-3-connect-dynamics-365-organization-to-omnichannel-chat-insights-app)
4.	[Step 4: Configure refresh frequency on Power BI Dataset](#step-4-configure-refresh-frequency-on-power-bi-dataset)
5.	[Step 5: Publish application within your organization](#step-5-publish-application-within-your-organization)
6.	[Step 6: Add Power BI Dashboard to Omnichannel Engagement Hub](#step-6-add-power-bi-dashboard-to-omnichannel-engagement-hub)

## Step 1: Review the prerequisites

Review the following prerequisites before configuring the supervisor dashboard:
-  You have administrative privileges for Dynamics 365 and Power BI.
-  You have a Power BI Pro license for all supervisors.
-  You must enable to embed Power BI reports in Dynamics 365 for Customer Engagement.
    1.	Sign in to **Dynamics 365 for Customer Service** and go to **Settings** > **Administration** > **System Settings**.
    2.	Go to **Reporting** tab and configure **Allow Power BI visualization embedding** as **Yes**.
    
      > [!div class=mx-imgBorder]
      > ![Enable to embed Power BI visualization](../media/supervisor-admin-enable-powerbi.png "Enable to embed Power BI visualization")
    
    3.	Select **OK**.

## Step 2: Install Dynamics 365 Omnichannel Historical Chat Analytics app

1.	Sign in to the [Power BI](https://app.powerbi.com/) app as an administrator.

2.	As a Power BI admin, Install [Dynamics 365 Omnichannel Insights](http://aka.ms/oc-chat-insights).

3.	After the **Dynamics 365 omnichannel insights** app is installed, select the app and configuration options page displays.

    > [!div class=mx-imgBorder]
    > ![Dynamics 365 Omnichannel insights configuration page](../media/supervisor-admin-historical-configuration-page-doi.png "Dynamics 365 Omnichannel insights configuration page")

    Now you can proceed to configure the app by connecting your Dynamics 365 organization.

## Step 3: Connect Dynamics 365 organization to Omnichannel Chat Insights app

1.	On the **Dynamics 365 omnichannel insights** app configuration page, select **Connect**.

    > [!div class=mx-imgBorder]
    > ![Select connect on configuration page](../media/supervisor-admin-historical-select-connect-data.png "Select connect on configuration page")

2.	On the connect data page, enter your organization's CRM OData feed URL and select **Next**.

    > [!div class=mx-imgBorder]
    > ![Enter CRM OData feed URL](../media/supervisor-admin-historical-crm-odata-field.png "Enter CRM OData feed URL")

3.	(Optional) To find the Microsoft Dynamics 365 OData URL, follow these steps:

    a.	Sign in to Dynamics 365 for Customer Service.
    
    b.	Go to **Settings** > **Customizations** and then select **Developer Resources**. 
    
    c.	Find the OData URL under **Service Root URL**.

       > [!div class=mx-imgBorder]
       > ![Get CRM OData feed URL](../media/supervisor-admin-historical-get-crm-odata-feed-url.png "Get CRM OData feed URL")

4.	Select Authentication method as OAuth2 and Privacy level as Organizational. Select Sign in.

    > [!div class=mx-imgBorder]
    > ![Enter authentication and privacy level](../media/supervisor-admin-historical-enter-auth-privacy-level.png "Enter authentication and privacy level")

5.	Enter your Dynamics 365 organization credentials and press **Enter**.

    When you are successfully signed in, the existing report will be updated with the data from your organization.

Now configure the refresh frequency for the reports and dashboards.

## Step 4: Configure refresh frequency on Power BI dataset

After you connect Dynamics 365 Omnichannel Chat Insights app with Dynamics 365 organization, you need to configure the refresh frequency on the Power BI dataset to refresh the report and dashboards properly.

1.	Sign in to [Power BI](https://app.powerbi.com/) app as administrator.

2.	Go to the Dynamics 365 omnichannel insights app workspace. 

    > [!div class=mx-imgBorder]
    > ![Select power bi workspace](../media/supervisor-admin-historical-powerbi-workspace.png "Select power bi workspace")

3.	Go to **Datasets** tab and select **Settings**.

    > [!div class=mx-imgBorder]
    > ![Select settings on datasets tab](../media/supervisor-admin-historical-settings-datasets-tab.png "Select settings on datasets tab")

4.	Turn on the **Scheduled refresh**.

    > [!div class=mx-imgBorder]
    > ![Turn on schedule refresh](../media/supervisor-admin-historical-schedule-refresh.png "Turn on schedule refresh")

    > [!NOTE]
    > We recommendation you to configure the refresh frequency as **Daily**.

5. Select **Apply**.

Omnichannel insight reports and dashboards will refresh daily. Now, publish the application in your organization.

## Step 5: Publish application within your organization

You must share the configured application with your entire organization so the supervisors can view the **Dynamics 365 Omnichannel Insights** dashboards and reports with their own **Power BI Pro** accounts.

1.	On the App workspace, select **Update app**.

    > [!div class=mx-imgBorder]
    > ![Select update app](../media/supervisor-admin-historical-select-update-app.png "Select update app")

2.	On the **Update app** wizard, go to the **Access** tab.

3.	Choose **Entire organization** and select **Update app**.

    > [!div class=mx-imgBorder]
    > ![Select entire organization option on access tab](../media/supervisor-admin-historical-access-level-select-org.png "Select entire organization option on access tab")

The app is now available to install for all individuals in your organization.

> [!NOTE]
> Verify that your administrator has allowed Omnichannel Engagement Hub to read and write data on behalf of users in your organization. To learn more, see [Provide data access consent](omnichannel-provision-license.md).

## Step 6: Add Power BI Dashboard to Omnichannel Engagement Hub

Each supervisor must configure their Dynamics 365 for Customer Engagement environment to integrate the Omnichannel Chat Insights and Omnichannel Sentiment Insights dashboards.

1.  Sign in to Dynamics 365 for Customer Service app.

2.  On the site map, select add icon (**+**) and then select **Dashboards**.

    > [!div class=mx-imgBorder]
    > ![Select dashboard to add](../media/supervisor-admin-select-dashboard.png "Select dashboard to add")  

3.  On the dashboard page, select **New** > **Power BI Dashboard**.

    > [!div class=mx-imgBorder]
    > ![Select Power BI dashboard option](../media/supervisor-admin-select-power-bi-dashboard-option.png "Select Power BI dashboard option")  

4.	Choose **Workspace** as **Dynamics 365 Omnichannel Chat Insights** and **Dashboard** as **Omnichannel Chat Insights**.

    > [!div class=mx-imgBorder]
    > ![Select Omnichannel Chat insights dashboard](../media/supervisor-admin-historical-select-omnichannel-insights.png "Select Omnichannel Chat insights dashboard")  

5.	Save and close.
6.	Repeat Step 3 to step 5 to add **Omnichannel Sentiment Analysis Insights** app.

    > [!div class=mx-imgBorder]
    > ![Select Omnichannel sentiment insights dashboard](../media/supervisor-admin-historical-select-sentiment-insights.png "Select Omnichannel sentiment insights dashboard")  

The Omnichannel Chat Insights and Omnichannel Sentiment Insights dashboards are now available in Dynamics 365.

## Add users to supervisor configuration

You must add users in the supervisor configuration to access any supervisor dashboard in **Unified Service Desk**. To add users in supervisor configuration, follow these steps:

1.  Sign in to Dynamics 365 for Customer Service.

2.  Go to **Settings** > **Unified Service Desk** and then select **Configuration**.

3.  On the configuration page, select **Supervisor Configuration**.

    > [!div class=mx-imgBorder]
    > ![Select supervisor configuration](../media/supervisor-admin-select-supervisor-configuration-add-user.png "Select supervisor configuration")  

4.  On the **Users** section, select **+ Add User record** and enter the user name to add the user.

    > [!div class=mx-imgBorder]
    > ![Add user to supervisor configuration](../media/supervisor-admin-supervisor-configuration-add-user.png "Add user to supervisor configuration")  

5.  Save and close the configuration.

    Users are added to the supervisor dashboard and when they sign in to Omnichannel on Unified Service Desk, the supervisor dashboard tabs are available.

### See also

-  [Introduction to Dynamics 365 omnichannel insights dashboard](../supervisor/intro-dynamics-365-omnichannel-insights-dashboard.md)

-   [Dynamics 365 omnichannel insights dashboards](../supervisor/omnichannel-insights-dashboard.md) 
