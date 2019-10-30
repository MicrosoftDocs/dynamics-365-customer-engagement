---
title: "Configure Customer Service Analytics Dashboard for Dynamics 365 | MicrosoftDocs"
description: "Learn about Customer Service Analytics"
keywords: ""
author: lerobbin
ms.author: lerobbin
manager: autumna
applies_to: 
ms.date: 10/29/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: f7b39a03-6e47-43bd-9c9b-f33170124a78
ms.custom: 
---

# Configure Customer Service Analytics Dashboard

You must perform the following steps to configure the historical customer service analytics dashboards to display in Customer Service Hub app: 

[Step 1: Review the prerequisites](#step-1-prerequisites )

[Step 2: Install Dynamics 365 Customer Service Analytics app](#step-2-install-dynamics-365-customer-service-analytics-app )

[Step 3: Connect Dynamics 365 organization to Customer Service Analytics app](#step-3-connect-dynamics-365-organization-to-customer-service-analytics-app)

[Step 4: Configure refresh frequency on Power BI Dataset](#step-4-configure-refresh-frequency-on-power-bi-dataset)

[Step 5: Publish application within your organization](#step-5-publish-application-within-your-organization )

[Step 6: Enable Power BI reporting in Dynamics 365 for Customer Engagement](#step-6-enable-power-bi-reporting-in-dynamics-365-for-customer-engagement ) 

[Step 7: Add Power BI Dashboard to Customer Service Hub](#step-7-add-power-bi-dashboards-to-customer-service-hub) 

### Step 1: Prerequisites 

Review the following prerequisites before configuring the supervisor dashboard: 

- You have administrative privileges for Dynamics 365 and Power BI. 
- You have a Power BI Pro license for all supervisors. 

### Step 2: Install Dynamics 365 Customer Service Analytics app 

1. Sign in to [Power BI](https://app.powerbi.com/) app as an administrator. 
2. As a Power BI admin, browse to this link: [http://aka.ms/cs-insights](http://aka.ms/cs-insights)
3. Install **Dynamics 365 Customer Service Analytics** app. 
4. After **Dynamics 365 Customer Service Analytics** app is installed, the app configuration options page displays. 
    
    > [!div class=mx-imgBorder]
    > ![Customer Service app install](media/cs-service-app-install.png "Customer Service app install view") 
    
    Now proceed to configure the app by connecting your Dynamics 365 organization. 

### Step 3: Connect Dynamics 365 organization to Customer Service Analytics app
 
 1. On the **Dynamics 365 Customer Service Analytics** app configuration options page, select **Connect data**. 
    
    > [!div class=mx-imgBorder]
    > ![Customer Service app install - connect data](media/cs-app-get-started.png "Customer Service app install connect data") 
    
2. On the connect data page, enter your organization's Dynamics 365 Service Root URL and select **Next**. 
    
    > [!div class=mx-imgBorder]
    > ![Customer Service app install - root url](media/cs-analytics-root-url.png "Customer Service app install - root url") 

3. (Optional) To find the Microsoft Dynamics 365 OData URL, follow these steps: 

    a. Sign into Dynamics 365 for Customer Engagement.

    b. Go to **Settings** and then select **Developer Resources**.  

    c. Find the OData URL under **Service Root URL**. 
    
    > [!div class=mx-imgBorder]
    > ![Customer Service app install - odata url](media/cs-analytics-odata-url.png "Customer Service app install - odata url") 

4. Select **Authentication method** as **OAuth2** and **Privacy level** as **Organizational**. Select **Sign in**. 
    
    > [!div class=mx-imgBorder]
    > ![Customer Service app install](media/cs-analytics-install.png "Customer Service app install") 
    
5. Enter your Dynamics 365 organization credentials and press **Enter**. 

    When you are successfully signed in, the existing report is updated with the data from your organization. 
    Now configure the refresh frequency for the reports and dashboards. 

### Step 4: Configure refresh frequency on Power BI Dataset 

After you connect Dynamics 365 Customer Service Analytics app with Dynamics 365 organization, you need to configure the refresh frequency on the Power BI dataset to update reports and dashboards properly.

1. Sign into Power BI app as administrator
2. Go to the **Dynamics 365 Customer Service Analytics** app **workspace**.
    
    > [!div class=mx-imgBorder]
    > ![Customer Service app install - refresh frequency](media/cs-analytics-refresh-frequency.png "Customer Service app install - refresh frequency")
    
3. Go to the **Datasets** tab and select **Settings**.
     
    > [!div class=mx-imgBorder]
    > ![Customer Service app install - data settings](media/cs-analytics-data-settings.png "Customer Service app install - data settings")
 
4. Turn **on** the **Scheduled refresh**.
     
    > [!div class=mx-imgBorder]
    > ![Customer Service app install - Scheduled refresh](media/cs-analytics-schedule-refresh.png "Customer Service app install - Scheduled refresh")

    Now, publish the application in your organization. 

 > [!NOTE]
 > We recommend you configure the refresh frequency to **Daily**. 

### Step 5: Publish application within your organization 

You must share the configured application with your entire organization for supervisors to view **Customer Service Analytics** dashboards and reports with their own **Power BI Pro** accounts.

1. On the App workspace, select **Update app**.
  
    > [!div class=mx-imgBorder]
    > ![Customer Service app install - Publish application](media/cs-analytics-publish-application.png "Customer Service app install - Publish application")
    
2. In the Update app wizard, go to the **Access** tab.

3. Choose **Entire organization** and select **Update app**.
     
    > [!div class=mx-imgBorder]
    > ![Customer Service app install - application](media/cs-analytics-update-app.png "Customer Service app install - application")

    The app is now available to install for all individuals in your organization. 
 
> [!NOTE]
> Verify your administrator has allowed users in your organization to have read/write data permissions in Omnichannel Engagement Hub. T To learn more, see [Provide data access consent](https://review.docs.microsoft.com/en-us/dynamics365/omnichannel/administrator/omnichannel-provision-license#provide-data-access-consent)  

### Step 6: Enable Power BI reporting in Dynamics 365 for Customer Engagement 
As an administrator, you must enable Power BI reporting in the Dynamics 365 for Customer Engagement organization for supervisors to view the dashboards in the Omnichannel Administration app. 

1. **Sign In** to Dynamics 365 for Customer Engagement and go to **Settings**.

2. Select **Administration, System Settings**.

3. Go to the **Reporting** tab and enable **Allow Power BI visualization embedding**.
     
    > [!div class=mx-imgBorder]
    > ![Customer Service app install - enable pbi](media/cs-analytics-enable-pbi.png "Customer Service app install - enable pbi")

    Supervisors can now configure dashboards. 
 
### Step 7: Add Power BI Dashboards to Customer Service Hub 

Each supervisor must configure their Dynamics 365 for Customer Engagement environment to integrate the Customer Service Analytics dashboard. 

1. Sign in to Dynamics 365 for Customer Engagement and open the **Customer Service Hub** app.
     
    > [!div class=mx-imgBorder]
    > ![Customer Service app install](media/cs-analytics-cs-hub.png "Customer Service app install")

2. Open **Supervisor Dashboards**.
     
    > [!div class=mx-imgBorder]
    > ![Customer Service app install](media/cs-analytics-supervisor-dashboard.png "Customer Service app install")

3. Select **New, Power BI Dashboard**.

    > [!div class=mx-imgBorder]
    > ![Power BI Dashboard](media/cs-pbi-dashboard-menu.png "Power BI Dashboard")

4. Choose **Workspace** as **Dynamics 365 Customer Service Analytics** and **Dashboard** as **Customer Service Analytics Dashboard**. 

    > [!div class=mx-imgBorder]
    > ![Power BI Dashboard Properties](media/cs-pbi-dashboard-properties.png "Power BI Dashboard Properties")

5. Save and close. 

   The Customer Service Analytics dashboard is now available in Dynamics 365.

## Add users to supervisor configuration  

You must add users in the supervisor configuration to access any supervisor dashboard in Unified Service Desk. To add users in supervisor configuration, follow these steps: 
 
 1. Log in to Dynamics 365.

 2. Go to **Settings, Unified Service Desk** and then select **Configuration**.

 3. On the configuration page, select **Supervisor Configuration**. 

    > [!div class=mx-imgBorder]
    > ![Supervisor Configuration](media/cs-supervisor-configurations.png "Supervisor Configuration")

 4. On the **Users** section, select **+ Add User record** and enter the user name to add the user.

     > [!div class=mx-imgBorder]
    > ![Add User Record](media/cs-add-user-record.png "Add User Record")

 5. Save and close the configuration.   

    Users are now added to the supervisor dashboard and when they log in to Omnichannel Engagement Hub on Unified Service Desk, the supervisor dashboard tabs are now available. 
 
## Customize Customer Service Analytics 
  
> [!IMPORTANT]
> Microsoft does not support customizations made to the Power BI template app and does not provide updates once modifications are made. 

Power BI is a comprehensive collection of services and tools that you use to visualize your business data. Power BI Template apps make it easy to visualize and analyze the Customer Service Analytics data with Power BI based on a standard data model. Customer Service Analytics template app is built with a set of entities and fields that useful for most reporting scenarios. 

Dynamics 365 apps are often extended with custom fields. These custom fields don’t automatically show up in Power BI model. This topic describes how you can edit and extend the report included in the template app to include custom fields in the Power BI model. 

Before you customize the template app, read the information here and perform each task, as necessary. 

### Prerequisites

- [Power BI service registration](http://powerbi.com "Power BI service registration").

- [Power BI Desktop](https://powerbi.microsoft.com/en-us/desktop/ "Power BI Desktop") application for editing Power BI reports. 

- PBIX file for customer service template app that you want to customize.

    [Download the Customer Service Analytics for Dynamics 365 PBIX](https://download.microsoft.com/download/f/4/a/f4ae41e2-b175-4536-bb52-4f0bdb5a2ae2/Customer%20Service%20Analytics%20for%20Dynamics%20365.pbix "Download the Customer Service Analytics for Dynamics 365 PBIX") application for editing Power BI reports. 

### Prepare a PBIX for customization 

1. Start Power BI Desktop. 
 
    Select **File** > Open, open Customer Service Analytics for Dynamics 365.pbix, and then select **Open**. 
 
    Several pages of reports are loaded and displayed in Power BI Desktop. 
 
2. On the Power BI Desktop ribbon, select **Edit Queries**. 
 
3. In the left navigation pane of the Edit Queries window, under **Queries**, select the **Dynamics 365 Service Root URL** query, and then on the ribbon, select **Advanced Editor**. 

    In the source definition, replace **contosuites.crm10.dynamics.com** with your apps instance URL. For example, if the organization name is <i>Contoso</i>, the URL looks like this: Source = https://contoso.crm.dynamics.com/api/data/v9.1/ 
 
4. Select **Done**, and then select **Close & Apply** in the Query Editor. 
 
5. When the Access an OData feed dialog appears, select **Organizational account**, and then select **Sign-in**.

    > [!div class=mx-imgBorder]
    > ![Access to OData feed](media/cs-odata-feed.png "Access to OData feed")

6. When the sign-in appears, enter your credentials to authenticate to your instance. 

7. In the Access an OData feed dialog, select **Connect**. 
 
    The queries are updated. This may take several minutes. 

## Customer Service Analytics for Dynamics 365 Template App Data Model Diagram 

   > [!div class=mx-imgBorder]
   > ![Customer Service Analytics for Dynamics 365 Template App Data Model Diagram](media/cs-template-app-data-model-diagram.png "Customer Service Analytics for Dynamics 365 Template App Data Model Diagram")

## See Also 

[Introduction to Customer Service Analytics](introduction-customer-service-analytics.md) 

[View and understand Customer Service Analytics](customer-service-analytics.md) 
