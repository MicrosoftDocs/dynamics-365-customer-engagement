---
title: "Model customization of historical analytics reports in Customer Service | MicrosoftDocs"
description: "Learn how to customize historical analytics reports in Dynamics 365 Customer Service using Power BI."
ms.date: 05/25/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
---

# Customize data models of historical analytics reports in Customer Service

Use the extensibility feature in Microsoft Power BI  to extend the out-of-the-box Dynamics 365 Customer Service Power BI data model and integrate with other datasets to create new custom metrics. You can customize the out-of-the-box standard reports and add your own KPIs and custom metrics to the reports to view the key metrics that are relevant to your organization. You can also drill down to add your metrics to the report as required.

The key capabilities of model customization include the ability to:

- Edit the out-of-the-box data model and add new metrics.

- Bring in your own custom entities from Dataverse or any other source and extend the Power BI data model.

- Publish the customized report to a specific Power BI workspace.

- Customize the report site map and enable users to access the reports natively from Customer Service workspace.

You can enable data model customization for historical analytics reports from the Customer Service admin center. This following describes how you can perform data model customization.

1. Understand how model customization works.
1. Configure pre-requisites  
1. Configure Power BI data model customization
    1. Identify a Power BI workspace.
    1. Provision the models and copy of reports.
    1. Grant permissions for data set and reports.
    1. Embed customized report back to Dynamics 365.
    
## Prerequisites

Before you begin with the customization, you must have the following prerequisites:

- At least one of the historical reports enabled for customer service manager in Omnichannel for Customer Service.
- Access to Power BI for Microsoft service account.
- Administrative privileges for Customer Service and Power BI.
- A Power BI Professional or Power BI Premium license for all supervisors and administrators.

- As a system administrator, you must create a security group in Microsoft Azure Active Directory (Azure AD) and add **Dynamics 365 Analytics** or **Dynamics CCA Data Analytics** as a member of the security group. More information: [Create a basic group and add members using Azure Active Directory](/azure/active-directory/fundamentals/active-directory-groups-create-azure-portal)

- As a Power BI administrator, you must add the security group created in Azure AD to Power BI service, after enabling the following in the Power BI admin portal:
  - **Service Principal** in the **Developer settings**. More information: [Enable service principals](/power-bi/enterprise/service-premium-service-principal#enable-service-principals)
  - **Create workspaces** in the **Tenant settings**. More information: [Create the new workspaces](/power-bi/admin/service-admin-portal-workspace#create-the-new-workspaces)
    
## Enable Power BI data model customization

 1. In the Customer Service admin center site map, select **Insights** in **Operations**.
 1. On the **Insights** page in the **Report settings** section, for **Embedded Power BI extensibility - Data model customization (preview)**, select **Manage**.
 1. On the **Embedded Power BI extensibility - Data model customization (preview)** page, set the **Enable embedded Power BI data model customization** toggle to **On**.
 
    :::image type="content" source="media/model-csac.png" alt-text="Enable Model customization in Customer Service admin center":::
 
## Select a Power BI workspace for historical analytics

You can select an existing workspace or create a new workspace where your customized reports will be published.

To create a new workspace:
 1. In Customer Service admin center, on the **Embedded Power BI report extensibility - Historical data model customization (preview)** page, **Step 1 of 3: Select workspace**, select **Create new workspace**.
 1. In the **Create Power BI workspace** dialog, provide a workspace name and select **Create**.
 1. Select **Save**. The report provisioning process is initiated.
 
    :::image type="content" source="media/enable-model-step1.png" alt-text="Select your workspace":::

> [!NOTE]
> - The report will be provisioned in your Power BI tenant and not in the Microsoft Power BI tenant. A hidden workspace will be created where the dataset will be hosted, which will connect to Power BI. The report will be provisioned in your workspace and the Power BI files will be published into this workspace.      
> - The out-of-the-box dataset is maintained by Customer Service and is refreshed daily. We recommend that you don't make changes to this dataset, as it might lead to malfunctioning of the report.

## Grant permissions for data set and reports

After the report is provisioned, perform the following steps to grant read or write permissions for Power BI users and read permissions for supervisors.

  :::image type="content" source="media/enable-model-step2.png" alt-text="Grant permissions for data set and reports":::

1. In Customer Service admin center, on the **Embedded Power BI report extensibility - Historical data model customization (preview)** page, **Step 2 of 3: Grant permissions for data set and reports**, select the **Power BI Data model** link. The Power BI Customer Service workspace appears.

     :::image type="content" source="media/share-report.png" alt-text="Give permissions":::

      1. Select **Share** to share the report. More information: [Share access to a dataset (preview)](/power-bi/connect-data/service-datasets-share)

      1. On the **Share dataset** dialog, search and provide the recipient's name or email address.
      1. Select the required permissions for the recipient from the following list:
      
          - Allow recipients to modify this data set.
          - Allow recipients to share this data set.
          - Allow recipients to build content with teh data associated with this dataset.
          - Send an email notification.
    
      1. Select **Grant access.**
   

1. Select the **Customized Power BI Report** link. The Power BI workspace where the sample reports will be provided appears. These reports are the copy of your out-of-the-box reports. You can make changes to the reports.

      :::image type="content" source="media/grant-permissions.png" alt-text="Grant permissions":::
1. Select **Access**. The Access dialog appears. If you want to embed the report back to Dynamics 365 and share it with someone, make sure you grant the person workspace contributor role or an equivalent role. 

### Edit an existing report or create a new one

> [!NOTE]
> Don't use hidden out-of-box facts or dimension fields in your custom reports as these fields might get modified or deleted.
    
1. After providing access, if you need to update a report, select the required report, and then select **Edit**.
    :::image type="content" source="media/model_update-report.png" alt-text="Update an existing report by selecting Edit option":::

1. You can create a report in one of the following ways:

   - Create a report online. In Customer Service admin center, on the **Embedded Power BI report extensibility - Historical data model customization (preview)** page, **Step 2 of 3: Grant permissions for data set and reports**, select the **Power BI Data model** link, and then from the **Create a report** dropdown list, select **Auto-create**.
       
       :::image type="content" source="media/model-create-report-online.png" alt-text="Create a report online from the Power BI data model"::: 

   - Create a report using Power BI Desktop, and create a live connection to datasets in the Power BI service. Before you create a report using Power BI Desktop, enable the [DirectQuery for Power BI datasets and Analysis Services](/power-bi/connect-data/desktop-directquery-datasets-azure-analysis-services#enable-the-preview-feature).
   
        1. On the Power BI desktop, select **Get Data**.
        1. On the **Get Data** dialog, select **Power Platform**, and then select **Power BI datasets**.
        1. Select **Connect**.
        1. On the **Data hub** dialog, select the report you want to embed to Customer Service, and then select **Connect**.
        1. On the **Connect to your data** dialog, select the database or the specific tables that you want to connect to.
        1. Select **Submit**.
        After the database or tables that you've selected in the previous step are added to your data model, on the **Microsoft Power BI Desktop** dialog, select **Save**.
        1. On the **Publish to Power BI** dialog, select the workspace that you specified in [Select a Power BI workspace for historical analytics](#select-a-power-bi-workspace-for-historical-analytics).
        
        Your reports will be published to Power BI.
        

## Add customized reports to Customer Service

After you've created and published the report, go back to the Customer Service admin center and add the custom reports. You'll now be able to select the custom reports that you want to see on the Customer Service workspace site map.

1. In Customer Service admin center, on the **Embedded Power BI report extensibility - Historical data model customization (preview)** page, **Step 3 of 3: Add report to sitemap**, select **Add report**.
1. On the **Add report** dialog, enter a name and select **Add**. You can add a maximum of 40 reports.
 
## View reports in Customer Service workspace

1. In the Customer Service workspace site map, select the **+** (plus) icon.
1. Select **Customized reports** from the dropdown list, and then select the report that you want to view.

## Data model and report mapping

For information on data model and report mapping, see [Data models and report mappings for historical analytics reports in Customer Service](oob-data-models.md#data-models-and-report-mappings-for-historical-analytics-reports-in-customer-service).

### See also

[Customize the visual display of your analytics reports](customize-reports.md#customize-the-visual-display-of-your-analytics-reports)  
[Introduction to Customer Service Insights](introduction-customer-service-analytics.md)  
[Configure Customer Service analytics and insights](configure-customer-service-analytics-insights-csh.md)  
[Configure Customer Service Analytics dashboards in Power BI](configure-customer-service-analytics-dashboard.md)  
[Configure Omnichannel historical analytics](oc-historical-analytics-reports.md)  
