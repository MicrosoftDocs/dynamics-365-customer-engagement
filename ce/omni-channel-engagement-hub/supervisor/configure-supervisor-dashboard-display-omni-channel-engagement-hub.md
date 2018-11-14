---
title: "How to configuere supervisor dashboards"
description: 
keywords: ""
author: udaykirang
ms.author: udag
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: 13992fe1-3d0a-47df-a2d7-c51d9441fabf
ms.custom: 
---
# Configure supervisor dashboard to display in Omni-channel Engagement Hub

The following diagram explains how to configure supervisor dashboard to display in Omni-channel Engagement Hub.

![steps to configure supervisor dashboard](media/oc-usd-supervisor-dashboard-configuration.png "Steps to configure supervisor dashboard")  

### Step 1: Prerequisites 

Review the following prerequisites before configuring the supervisor dashboard: 

-   You have administrative privileges for Dynamics 365. 

<!-- -->

-   You must have Power BI Pro license for all supervisors. 

-   You must have an Azure account . 

### Step 2: Register Azure AD native app with Power BI API permissions 

Create a native app in Azure AD and provide access to Power BI REST APIs to this app. Perform the following steps to register an Azure native app: 

1.  Go to [*Power BI application registration*](https://dev.powerbi.com/apps) page and log in to the app.  

2.  Enter the basic information **App Name**, **Type**, and **URL**.

**Note:** Select **App Type** as **Native app**.

1.  In the **Choose APIs to access** section, select all the **Dataset APIs**, **Report and Dashboard APIs**, and **Other APIs**.

2.  Select **Register App**.

3.  When you register the app, the client ID is displayed. Keep a note of this client ID.  

For example, the client ID value will be displayed as 2da2165-0def-4252-b4cb-760534af096d.

More information: [Register with the Power BI App Registration Tool](https://docs.microsoft.com/en-us/power-bi/developer/register-app)

Now, you are ready to create an Azure Key Vault for your application. 

### Step 3: Create Azure Key Vault 

Creating the Key Vault for your tenant helps you in securely store the passwords, certificates, and other secrets. Perform the following steps to create Azure Key Vault: 

1.  Log in to [*Azure Portal*](http://portal.azure.com).  

2.  Create Key Vault. More information: [Create a vault](https://docs.microsoft.com/en-us/azure/key-vault/quick-create-portal#create-a-vault)  

3.  Add the following secrets to your created key vault.

| Key           | Value (Secret)                                                     |
|---------------|--------------------------------------------------------------------|
| PowerBiUser   | Your admin username. For example,  *admin@contoso.onmicrosoft.com* |
| PowerBiPass   | Your administrator password.                                       |

More information: [Add a secret to Key Vault](https://docs.microsoft.com/en-us/azure/key-vault/quick-create-portal#add-a-secret-to-key-vault)   

### Step 4: Grant access to the Omni-channel app for the created Key Vault 

To provide access to your native app for the created Key Vault, follow these steps: 

1.  Log in to [*Azure Portal*](http://portal.azure.com) and open your Key Vault.   

<!-- -->

1.  Go to Access policies, select **+ Add new** and then select **Configure from template (optional)** as **Key, Secret, & Certificate Management**. 

<!-- -->

1.  Select **Select principal** and add **OmniChannel** app that is registered during consent flow. 

<!-- -->

1.  Save and close.

2.  Go to the **Overview** section and copy the **DNS Name**. This helps in provision Power BI reports in your workspace.

Now your application is secured and ready to use in the Dynamics 365.

More information: [*Authorize the application to use the key or secret*](https://docs.microsoft.com/en-us/azure/key-vault/key-vault-get-started)   

### Step 5: Log in to Power BI and create an app workspace 

Create app workspace in Power BI to add and refine collections of dashboards and reports that are meant for supervisor. Perform the following steps to create app workspace:  

1.  Log in to **Power BI** service and go to **Workspaces** &gt; **Create app workspace**. 

<!-- -->

1.  Enter the necessary information and save the workspace. 

The workspace is created. In the workspace URL, keep a note of the workspace ID.

For example, when a workspace is created, the URL is displayed as:

<https://msit.powerbi.com/groups/7b712501-788g-41e9-a136-30484a39f09f/groupWelcome>

The workspace ID value is 7b712501-788g-41e9-a136-30484a39f09f.

More information: [*Create workspaces with your colleagues in Power BI*](https://docs.microsoft.com/en-us/power-bi/service-create-workspaces).   

### Step 6: Provision Power BI reports in your workspace 

When you provision the Power BI reports, the **SupervisorOverviewComputational** and **SupervisorOverviewOperational** reports will be available in your workspace. These reports are necessary to create dashboards for supervisor.  

To provision your supervisor reports, follow these steps: 

1.  Log in to **Dynamics 365** and open **Omni Channel Engagement Hub** app. 

![open omni channel engagement hub](media/oc-usd-supervisor-dashboard-configuration-open-oceh.png "Open omni channel engagement hub")

1.  Select **Site Map** ![site map icon](media/oc-usd-supervisor-dashboard-site-map.png "Site map icon"), and then select **Supervisor experience**, **Overview dashboard**.    

The analytics view opens.

![active analytics view to coinfigure power bi](media/oc-usd-supervisor-dashboard-active-analytics-view.png "Active analytics view to coinfigure power BI")

1.  Select **+ New**. 

The **Power BI Analytics Configuration** page opens.

![coinfigure power bi values](media/oc-usd-supervisor-dashboard-configure-powerbi-values.png "Coinfigure power BI values")

1.  Enter the following information: 

- **Power BI native app ID:** Enter the client ID that you have noted while registering Azure AD native app to embed Power BI content in [Step 2: Register Azure AD native app with Power BI API permissions](#_Step_2:_Register).   

For example: Power BI native app ID as 2da2165-0def-4252-b4cb-760534af096d

- **Power BI workspace ID:** Enter the workspace ID that is created when you created app workspace as specified in [Step 5: Log in to Power BI and create an app workspace](#_Step_5:_Log).    

For example: Power BI workspace ID as 1d3b66s1-650f-44f7-8bc9-d9bdc67e8540

- **Azure Key Vault URI:** Enter the URI that you have obtained while creating the Power BI application registration as specified in [Step 4: Grant access to the Omni-channel app for the created Key Vault](#_Step_4:_Grant).   

For example: Azure Key Vault URI as https://yourkeyvault.vault.azure.net/

1.  Save and close the configuration. 

You should now have the **SupervisorOverviewComputational** report available in your workspace.

**Important!** Do not create more than one analytics configuration in your Dynamics 365. If you have more than one, the application uses only the latest analytics that you have created. However, if you want to add new analytics configuration, delete or deactivate the existing and add the new.

1.  Download the **SupervisorOverviewOperational** report file (.pbit) from [GitHub](https://github.com/Microsoft/BusinessPlatformApps/tree/dev/Samples/D365OmniChannel/Preview).  

Now, you have the necessary reports to configure the dashboards in Power BI. 

### Step 7: Configure Power BI dashboards using Power BI Desktop

Create the Power BI dashboard out of the two reports that are available to you **SupervisorOverviewComputational** and **SupervisorOverviewOperational**. When you provision the workspace, the following data sets and reports are available: 

-   SupervisorOverviewComputational (dataset) 

-   MicrosoftDynamicsOCAnalytics (dataset) 

-   SupervisorOverviewComputational (report) 

-   SupervisorOverviewOperational (report) 

**Important!** In PowerBI, share the dashboards with all supervisors who use Omini-channel Engagement Hub. If not shared, the supervisors cannot view the dashboards when logged in to the Omni-channel Engagement Hub. More information: [*Share your Power BI dashboards and reports with coworkers and others*](https://docs.microsoft.com/en-us/power-bi/service-share-dashboards).   

Follow the steps: 

1.  Open the **Power BI Desktop** app and log in with your credentials.

2.  Go to the work space that you have created in [step 5: Log in to Power BI and create an app workspace](#_Step_5:_Log).  

3.  Go to **File** &gt; **Import** &gt; **Power BI template** and select the downloaded **SupervisorOverviewOperational.pbit**.

    A dialog is displayed.

4.  Select **Edit** on the message.

5.  On the **Power BI service** dialog, choose your workspace and select the dataset.

6.  Change to your organization created workspace and select the dataset **MicrosoftDynamicsOCAnalytics**.

 **Note:** The **MicrosoftDynamicsOCAnalytics** dataset may take up to 15 minutes to appear in the created workspace. 

7.  Publish and save the pbix file to the created workspace. 

Now, reports are created.

1.  Open the reports that are available in the workspace. More information: [*Open a report in Power BI service*](https://docs.microsoft.com/en-us/power-bi/service-report-open)   

2.  Pin the required tiles to dashboards. More information: [Pin a tile to a Power BI dashboard from a report](https://docs.microsoft.com/en-us/power-bi/service-dashboard-pin-tile-from-report)    

The following page is an example of how a dashboard displays when you pin tiles: 

![live work monitoring for supervisor](media/oc-usd-supervisor-overview-live-monitoring.png "Live work monitoring for supervisor")  

1.  Select **Set as featured** for the created dashboard.

2.  Copy the URL of the dashboard for Unified Service Desk configuration.  

The dashboards are ready, and you can configure the Unified Service Desk to make the dashboards available for supervisors.

More information: [*Create a new report in Power BI service by importing a dataset*](https://docs.microsoft.com/en-us/power-bi/service-report-create-new)   

### Step 8: Configure Unified Service Desk to display supervisor dashboard

You must configure the Unified Service Desk to display the supervisor dashboards when a supervisor signs in to the workspace in Omni channel. To configure the Unified Service Desk, follow these steps:

1.  Log on to Dynamics 365 and go to **Settings**, **Unified Service Desk**.

    The Unified Service Desk settings page opens.

2.  Select **Action Calls** and open **Load Supervisor Dashboard**.

3.  In the **Action** section, enter the **Data** as “*url=* *https://powerbi.com/dashboards/&lt;id&gt;*” that you saved in [Step 7: Configure Power BI dashboards using Power BI Desktop](#_Step_7:_Configure). Also, add the **chromeless=1** and n**osignupcheck=1** parameters at the end of the URL.  

    For example,

    url=*https://powerbi.com/dashboards/g12466b5-a452-4e55-8634-xxxxxxxxxxxx?chromeless=1&nosignupcheck=1*

4.  Save and close the settings page.

    The supervisor dashboard is configured, and supervisors can now log on to the Omni channel and view the dashboard.

