---
title: Add Dynamics 365 (online) as a data source | Microsoft Docs
description: This section takes you through the steps to add a data source to Customer Insights.
keywords: dynamics 365; customer insights
Applies_to: Dynamics 365 for Customer Insights
author: jimholtz
ms.author: jimholtz
manager: brycho
ms.date: 07/03/2017
ms.topic: get-started-article
ms.service: customer-insights 
ms.assetid: 0b4f076f-8053-4789-9483-f414321a3d86
---

Add [!include[](../../includes/pn-crm-online.md)] as a data source
==========================
[!include[pre release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

If you need to import data from your [!include[](../../includes/pn-crm-online.md)] instance into [!include[](../../includes/pn-customer-insights-full.md)], please have the [!include[](../../includes/pn-dynamics-crm.md)] Administrator credentials for your [!include[](../../includes/pn-dynamics-crm.md)] organization ready.

![About Dynamics 365 Connector](../media/ConceptCRMConnector.png "About Dynamics 365 Connector") 

>[!NOTE]
>**TRY IT!** <br>
If you have an instance of [!include[](../../includes/pn-crm-online.md)] with the sample data installed, you can use it for your data connection. We'll use the sample data for data modeling and Customer 360. You'll need to have the Customer Service app installed. <br>
>If you don't have an instance of [!include[](../../includes/pn-crm-online.md)], you can sign up for a 30-day trial and try out [!include[](../../includes/pn-customer-insights-short.md)] with our sample data. Go to [Microsoft Dynamics 365 for Customer Service](https://go.microsoft.com/fwlink/p/?linkid=829708), and then select **Get Started**.

##To use [!include[](../../includes/pn-crm-online.md)] as a data source by using the [!include[](../../includes/pn-azure-portal.md)]

1.  On your [!include[](../../includes/pn-customer-insights-short.md)] hub blade, select **Data Sources** .

2.  On the **All Data Sources** blade, select **Add**.

    ![Add a data source](../media/AddAzureBlobDataSource.png "Add a data source") 

3.  On the **New Data Source** blade, select **Data Source Type**.

4.  On the **Data Source Type** blade, select **Dynamics 365**.

    ![Select the Dynamics 365 data source type](../media/CRMDataSourceType.png "Select the Dynamics 365 data source type") 

5.  Enter a **Name** for the data source, and then select **Login to CRM**.

    ![New data source name](../media/NewDataSourceName.png "New data source name") 

6.  This opens a new window for you to sign in to your [!include[](../../includes/pn-crm-online.md)] instance. You must use **Dynamics 365 Administrator credentials** for this sign-in.

7.  If the sign-in is successful, the **New Data Source** blade will be updated with the logged-in ID and the [!include[](../../includes/pn-dynamics-crm.md)] organization name.

    ![Log in to the new data source](../media/NewDataSourceLogin.png "Log in to the new data source") 

8.  Select **Configure required settings** to open the **Select Entities** blade. Depending on your [!include[](../../includes/pn-dynamics-crm.md)] configuration, the entities you see might be different from the ones below.

    ![Select the Entities blade](../media/SelectEntitiesBlade.png "Select the Entities blade") 

9.  Select the entities to import into [!include[](../../includes/pn-customer-insights-short.md)]. This displays a check mark next to the selected entity.

10.  If an entity should be modeled as a profile, choose **Yes** under **Is Profile**; otherwise, entities will be imported as interactions.

     ![Select entities to model as a profile](../media/SelectEntitiesToModelAsProfile.png "Select entities to model as a profile") 

   >[!NOTE]
   >**TRY IT!** <br>
   >Use the following entities:<br>
    | Entity| Is Profile |                                                                                                                                              
    |-------|-----------------|
    | Account     | Yes |
    | Case        | Yes |
    | Contact     | Yes |
    | Product        | Yes |
    | Email     | No |
    | Phone Call        | No |

11.  On the **Select Entities** blade, select **OK**.

12.  On the **New Data Source** blade, select **Create** to provision [!include[](../../includes/pn-crm-online.md)] as your data source.<br>
     It will take several minutes for the connection to be established. Refresh your browser to update the status.

     ![The data connection is being created](../media/CreatingDataSource650.png "The data connection is being created") 

13.  When the status becomes **Created**, select the **Activate** icon to activate the connection.

     ![Activate the data connection](../media/ActivateConnection650.png "Activate the data connection") 

14.  After the connection is active, verify that data is being synchronized between [!include[](../../includes/pn-azure-shortest.md)] and [!include[](../../includes/pn-dynamics-crm.md)]. <br>
Close the **All Data Sources** blade, and open the **Profiles** and **Interactions** blades. You should see some values that aren't zero. It might take up to 24 hours for the data to be synchronized between [!include[](../../includes/pn-dynamics-crm.md)] and [!include[](../../includes/pn-azure-shortest.md)]. 

     ![Some profiles should show data](../media/ProfilesShowingData650.png "Some profiles should show data") 

Each [!include[](../../includes/pn-dynamics-crm.md)] entity you import into [!include[](../../includes/pn-customer-insights-short.md)] will have a corresponding interaction that appears on the **Interactions** blade. In addition, each entity imported as a profile will have a corresponding **Profile** type in [!include[](../../includes/pn-customer-insights-short.md)] that appears on the **Profiles** blade.

