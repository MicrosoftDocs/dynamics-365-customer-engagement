---
title: "Connect conversation intelligence to an environment"
description: "Use data source to connect or disconnect multiple environments with conversation intelligence."
ms.date: 09/30/2022
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
---
# Connect conversation intelligence to an environment  

If you have multiple environments in your organization, you can connect the Conversation intelligence app to more than one environment. This will allow you to switch to different environments from the Conversation intelligence app and view the call insights. 

At a time, you can have only one active environment that is connected to the application. When you activate an environment, the existing environment will automatically deactivate, and the new environment’s data 
will be displayed on the application. 

> [!NOTE]
> Throughout this article, environment refers to a [Power Platform environment with a Dataverse database](/power-platform/admin/create-environment#create-an-environment-with-a-database) that hosts Dynamics 365 Sales.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## To connect to an environment 

1.	Review the prerequisites. To learn more, see [Prerequisites to configure conversation intelligence](prereq-sales-insights-app.md).

2.	Sign in to the [Conversation intelligence app](https://sales.ai.dynamics.com/). 

3.	Select the **Settings** icon on the top-right of the page and then select **Settings**.

    > [!div class="mx-imgBorder"]
    > ![Select settings option](media/si-app-admin-select-settings.png "Select settings option")

4.	On the **Settings** page, select **Data source**. 
 
5.	In the **Dynamics 365 environment** section, select **Add an environment**.
 
6.	In the **Connect your data** dialog box, select the Power Platform environment that hosts Dynamics 365 Sales, to connect with the application.

    > [!div class="mx-imgBorder"]
    > ![Select the environment](media/si-app-admin-connect-d365-organization.png "Select the environment")

    The application now detects your environment.

7.	In the **Terms and conditions** dialog box, accept the terms and conditions, and continue.
 
    The application takes few minutes to connect to your environment and data, and a progress dialog box is displayed.
 

11.	Select **Finish** to complete the setup.
  
The Conversation intelligence app is now connected to the environment.  Managers and sellers can use it to [view call insights](view-and-understand-call-summary.md).

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Introduction to administer conversation intelligence](intro-admin-guide-sales-insights.md#administer-conversation-intelligence)

[Prerequisites to configure conversation intelligence](prereq-sales-insights-app.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
