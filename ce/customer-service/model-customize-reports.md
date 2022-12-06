---
title: "Model customization of historical analytics reports in Customer Service | MicrosoftDocs"
description: "Learn how to customize historical analytics reports in Dynamics 365 Customer Service using Power BI."
ms.date: 12/06/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365CS
---

# Customize data models of historical analytics reports in Customer Service (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

Use the extensibility feature in Microsoft Power BI  to extend the out-of-the-box Dynamics 365 Customer Service Power BI data model and integrate with other datasets to create new custom metrics. You can customize the out-of-the-box standard reports and add your own KPIs and custom metrics to the reports to view the key metrics that are relevant to your organization. You can also drill down to add your metrics to the report as required.

The key capabilities of model customization include the ability to:

- Edit the out-of-the-box data model and add new metrics.

- Bring in your own custom entities from Dataverse or any other source and extend the Power BI data model.

- Publish the customized report to a specific Power BI workspace.

- Customize the report site map and enable users to access the reports natively from Customer Service workspace.

This article describes how to enable the data model customization feature and set up the workspace for Microsoft to provision the out-of-the-box data model in a read-only workspace, and a workspace where the customized report can be published to render it in Customer Service workspace. The tasks that you need to perform are as follows.

1. Select a Power BI workspace for historical analytics
1. Grant permissions for dataset and reports
1. Add customized reports in Dynamics 365
1. View reports in Customer Service workspace
1. Data model and report mapping


## Prerequisites

Before you begin with the customization, you must have the following prerequisites:

- At least one of the historical reports enabled for customer service manager in Omnichannel for Customer Service.
- Access to Power BI for Microsoft service account.
- Administrative privileges for Customer Service and Power BI.
- A Power BI Professional or Power BI Premium license for all supervisors and administrators.

- As a system administrator, you must create a security group in Microsoft Azure Active Directory (Azure AD) and add **Dynamics 365 Analytics** or **Dynamics CCA Data Analytics** as a member of the security group. More information: [Create a basic group and add members using Azure Active Directory](/azure/active-directory/fundamentals/active-directory-groups-create-azure-portal)

- As a Power BI administrator, you must add the security group created in Azure AD to Power BI service, after enabling the following in the Power BI admin portal:
  - **Service Principal** in the **Developer settings**.
  - **Create workspaces** in the **Tenant settings**.
   
    a. Sign in to [Power BI service](https://app.powerbi.com), and then go to **Settings** > **Admin portal**.

    :::image type="content" source="media/supervisor-admin-powerbi-select-admin-portal.png" alt-text="Navigate to admin portal":::

   b. In the admin portal, go to **Tenant settings** > **Developer settings** > **Allow service principals to use Power BI APIs**.

   c. Enable **Allow service principals to use Power BI APIs** by setting the toggle to **Enabled**, and specify the security group to which you want to give access by selecting **Specify the security groups (Recommended)** option and then entering the security groups.

    :::image type="content" source="media/supervisor-admin-enable-service-principals.png" alt-text="Enable service principals for security groups":::
      
   d. Select **Apply**.
      
   e. Go to **Tenant settings** > **Workspace settings**> **Create workspaces (new workspace experience)**.
      
   f. Enable **Create workspaces (new workspace experience)** by setting the toggle to **Enabled**, and specify the security group to which you want to give access by selecting **Specify security groups** option and then entering the security groups.
      
   :::image type="content" source="media/supervisor-admin-enable-create-workspaces.png" alt-text="Create workspaces":::
      
   g. Select **Apply**.
    
## Enable the option to extend the out-of-the-box Power BI data model

 1. In the Customer Service admin center site map, select **Insights** in **Operations**.
 1. On the **Insights** page in the **Report settings** section, for **Embedded Power BI extensibility - Data model customization (preview)**, select **Manage**.
 1. On the **Embedded Power BI extensibility - Data model customization (preview)** page, set the **Enable embedded Power BI data model customization** toggle to **On**.
 
    :::image type="content" source="media/model-csac.png" alt-text="Enable Model customization in Customer Service admin center":::
 
## Select a Power BI workspace for historical analytics

You can select an existing workspace or create a new workspace where your customized reports will be published.

To create a new workspace:
 1. In Customer Service admin center, on the **Embedded Power BI report extensibility - Historical data model customization (preview)** page, step 1, select **Create new workspace**.
 1. In the **Create Power BI workspace** dialog, provide a workspace name and select **Create**.
 1. Select **Save**. The report provisioning process is initiated.
 
    :::image type="content" source="media/enable-model-step1.png" alt-text="Select your workspace":::

> [!NOTE]
> - The report will be provisioned in your Power BI tenant and not in the Microsoft Power BI tenant. A hidden workspace will be created where the dataset will be hosted, which will connect to Power BI. The report will be provisioned in your workspace and the Power BI files will be published into this workspace.      
> - This dataset is maintained by Customer Service and is refreshed daily. We recommend that you don't make changes to this dataset, as it might lead to malfunctioning of the report.

## Grant permissions for dataset and reports

After the report is provisioned, perform the following steps to grant authoring (read or write) permissions for Power BI users and read permissions for supervisors.

  :::image type="content" source="media/enable-model-step2.png" alt-text="Grant permissions for data set and reports":::

1. In Customer Service admin center, on the **Embedded Power BI report extensibility - Historical data model customization (preview)** page, step 2, select the **Power BI Data model** link. This will take you to the Power BI Customer Service workspace.
 :::image type="content" source="media/share-report.png" alt-text="Give permissions":::

      1. Select **Share** to share the report. More information: [Share access to a dataset (preview)](/power-bi/connect-data/service-datasets-share)

      1. On the **Share dataset** dialog, search and provide the recipient's name or email address.
      1. Select the checkboxes for the various permissions that you want to set for the recipient.
      1. Select **Grant access.**
   
           :::image type="content" source="media/share-dataset.png" alt-text="Search for recipients on the Share dataset dialog":::

1. Select the **Customized Power BI Report** link. This will take you to the workspace in Power BI where the sample reports will be provided. These reports are the copy of your out-of-the-box reports. You can make changes to the reports.

      :::image type="content" source="media/grant-permissions.png" alt-text="Grant permissions":::
    1. Select **Access**.
    1. If you want to embed the report back to Dynamics 365 and share it with someone, make sure you grant the person workspace contributor role or higher.
    
     :::image type="content" source="media/grant-permissions_role.png" alt-text="Grant roles":::

1. After providing access, if you need to update a report, select the required report, and then select **Edit**. 
    :::image type="content" source="media/model_update-report.png" alt-text="Update an existing report by selecting Edit option":::

1. You may also create a report in one of the following ways:

   1. Create a report online.
       1. Select the Power BI data model in Step 2, and then from the **Create a report** dropdown list, select **Auto-create**.
       
       :::image type="content" source="media/model-create-report-online.png" alt-text="Create a report online from the Power BI data model"::: 

   1. Create a report using Power BI Desktop, and create a live connection to datasets in the Power BI service:
        1. On the Power BI desktop, select **Get Data**.
        1. On the **Get Data** dialog, select **Power Platform**, and then select **Power BI datasets**.
        1. Select **Connect**.
        :::image type="content" source="media/model-powerdataset.png" alt-text="Select Power BI dataset":::
        1. On the **Data hub** dialog, select the report you want to embed to Customer Service, and then select **Connect**.
        :::image type="content" source="media/model-data-hub-dialog.png" alt-text="Select your report on the Data hub dialog":::
        1. On the **Connect to your data** dialog, select the database or the specific tables that you want to connect to.
        1. Select **Submit**.
        :::image type="content" source="media/model-select-dataset.png" alt-text="Select your tables that you want to connect to.":::
        
        1. After the database or tables that you have selected in the previous step are added to your data model, save the changes you made to your file.
        1. On the **Publish to Power BI** dialog, select the workspace that you specified in Step 1, and then select **Select**.
         :::image type="content" source="media/model-select-workspace-created-in-step-two.png" alt-text="Select the destination which you specified in Step 2":::
           Your reports will be published to Power BI.
        

## Add customized reports in Dynamics 365

After you've created and published the report, go back to the Customer Service admin center and add the reports. You'll now be able to select the reports that you want to see on the Customer Service workspace site map.

:::image type="content" source="media/enable-model-step3.png" alt-text="Add report to site map":::

1. In Customer Service admin center, on the **Embedded Power BI report extensibility - Historical data model customization (preview)** page, step 3, select **Add report**.
1. Enter a name and select **Add**. You can add a maximum of 40 reports.
 
## View reports in Customer Service workspace

1. In the Customer Service workspace site map, select the **+** (plus) icon.
1. Select **Customized reports** from the dropdown list, and then select the report that you want to view.

:::image type="content" source="media/customized-reports-option.png" alt-text="View your reports in Customer Service workspace":::

## Data model and report mapping

For more information on data model and report mapping, see [Data models and report mappings for historical analytics reports in Customer Service](oob-data-models.md#data-models-and-report-mappings-for-historical-analytics-reports-in-customer-service).
### See also

[Customize visual display of historical analytics reports in Customer Service](customize-reports.md#customize-visual-display-of-historical-analytics-reports-in-customer-service)  
[Introduction to Customer Service Insights](introduction-customer-service-analytics.md)  
[Configure Customer Service analytics and insights](configure-customer-service-analytics-insights-csh.md)  
[Configure Customer Service Analytics dashboards in Power BI](configure-customer-service-analytics-dashboard.md)  
[Configure Omnichannel historical analytics](oc-historical-analytics-reports.md)  
