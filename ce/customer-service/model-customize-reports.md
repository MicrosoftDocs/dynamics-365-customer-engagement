---
title: "Model customization of historical analytics reports in Customer Service | MicrosoftDocs"
description: "Learn how to customize historical analytics reports in Dynamics 365 Customer Service using the Power BI embedded editing experience."
ms.date: 09/13/2022
ms.topic: article
author: lalexms
ms.author: laalexan
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

# Model customization of historical analytics reports in Customer Service

Dynamics 365 Power BI extensibility capability enables power users to extend out-of-box customer service Power BI data model and integrate with other data sets to produce new custom metrics.

Customizing the out-of-the-box standard reports and adding your own KPIs and custom metrics to the reports will enable you to view the key metrics that are relevant to your organization.

Key capabilities of model customization include the ability to:

- Edit out-of-the-box data model and add new metrics in addition to the out-of-the-box metrics.

- Bring in your own custom entities from Dataverse or any other source and extend Power BI data model.

- Publish the customized report to a specific Power BI workspace.

- Customize the report site map and enable users to access the reports natively from the Customer Service workspace.

## Prerequisites

- You must have the Power BI premium license.

- Power Users must have the Power BI professional license to be able to extend the out-of-the-box data model.

- Power BI desktop is required to open the model and make necessary changes.

## Enable model customization of your analytics reports from Customer Service workspace

This section describes how to enable data model customization feature and set up the workspace for Microsoft to provision out of box data model in a “Read-only” workspace and a workspace where the customized report can be published to render it in the Customer Service workspace.

### Prerequisites

- Have at least one of the historical reports enabled for Customer service manager, Omnichannel 
- Provide access to Power BI for Microsoft service account.
- You must have administrative privileges for Dynamics 365 Customer Service and Power BI.
- You must have a Power BI Pro or Power BI Premium license for all supervisors and administrators.
- As a system administrator, you must create and add a security group for Power BI service. Perform the following steps to create and add a security group: 
  1. Create a security group in Azure Active Directory (Azure AD), and add Dynamics CCA Data Analytics as a member to that security group.  
More information: Create a basic group and add members using Azure Active Directory.
  2. As a Power BI admin, enable the service principal in the Developer settings in the Power BI admin portal and the security group that you created in Azure AD. 

     1. Sign in to Power BI service and go to Settings > Admin portal.
     2. In the admin portal, go to Tenant settings > Developer settings > Allow service principals to use Power BI APIs.
     1. Enable Allow service principals to use Power BI APIs and specify the security group to which you want to give access.
     1. Select **Apply**.

## Enable model customization of your analytics reports from Customer Service admin center

1.	In the site map, select **Insights** in **Operations**. The **Insights** page appears.
2. In the **Embedded Power BI extensibility - Data model customization (preview)** section, select **Manage**.
3. Select a workspace from the dropdown list or select **Create new workspace** and provide a workspace name.
3. Select **Save**. The report provision process is initiated.

### Share the data model and workspace

Once the customization is enabled, perform the following steps to share the data model and workspace:

1. Select **Give permissions to access out-of-the-box Power BI Data model**.
This will take you to the dataset file. Note that this dataset is maintained by Dynamics Customer Service and is refreshed on a daily basis. It is recommended to not make changes to this dataset, otherwise it will lead to the report malfunction. 

2. Share the report to the people who would like to create new report/view the report by clicking on the share button at left top More details : https://docs.microsoft.com/en-us/power-bi/connect-data/service-datasets-share

3. Click on the Give permissions to Customized power bi Report, this will  take you to the workspace where we will drop the sample reports. These reports are the copy of your oob reports, the connection is taken care of, just go ahead and make changes.

Go to <<maker experience to update the data model/ report >>.

### Create and save the site map

1. Once you have the report created and published, go back to the customer service admin page, click on the add reports, select the report you want to embed back to customer service, give it a name and click on add. You can add up to 40 reports 

2. Once you have all the reports added, click on save to persist the setting, you can always go back to adjust the order or make change to them.

### Render reports

Go to customer service workspace and click on customized reports, your report will be rendered 

## Enable model customization of your analytics reports from Power BI workspace

This section describes how you can update the out-of-the-box Power BI data model and add external dataset to build new custom metrics and publish it into your Power BI workspace.  

1. Open power BI report from the workspace.

2. Connect new data set from an excel sheet.

3. Update the OOB data model and differentiate the queue by departments.

4. Build a report specific for departments.

5. Publish the report to the Power BI workspace configured.

## Data model and out of box Power BI reports

(Need info)


### See also

[Visual customization of historical analytics reports in Customer Service](customize-reports.md#visual-customization-of-historical-analytics-reports-in-customer-service)
[Introduction to Customer Service Insights](introduction-customer-service-analytics.md) <br>
[Configure Customer Service analytics and insights](configure-customer-service-analytics-insights-csh.md) <br>
[Configure Customer Service Analytics dashboards in Power BI](configure-customer-service-analytics-dashboard.md) <br>
[Configure Omnichannel historical analytics](oc-historical-analytics-reports.md)
