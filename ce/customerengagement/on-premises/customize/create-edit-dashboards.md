---
title: "Create or edit system dashboards | MicrosoftDocs"
ms.custom: 
ms.date: 06/12/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 641885d2-4a08-41b8-b914-d9a244e4d5b1
caps.latest.revision: 10
ms.author: matp
manager: kvivek
author: Mattp123
search.audienceType: 
  - customizer

---
# Create or edit system dashboards

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Create or edit model-driven app dashboards](/powerapps/maker/model-driven-apps/create-edit-dashboards) 

There are two types of dashboards, user dashboards and system dashboards. Any user can create a dashboard visible only to them in their work area such as Sales, Service, or Marketing. An admin or customizer creates or customizes system dashboards that, when published, are visible to everyone in the organization. A user can choose to set their user dashboard as their default dashboard and override the system dashboard. 

This topic focuses on how to create a system dashboard. To create a user dashboard, see [Create a personal dashboard](../basics/start-your-day-dashboard-chart.md#create-a-personal-dashboard). 
  
<a name="BKMK_createdashboard"></a>   
## Create a new dashboard  
  
1.  Open solution explorer, and then select **Components** > **Dashboards**.  
  
2.  Select **New**, choose a layout, and then select **Create**.  
  
3.  In the **Dashboard: New** dialog box enter a name for the dashboard.  
  
4.  Select one of the component areas and then select the icon for a chart or a list.  
  
     You can have up to six components in the dashboard.  
  
5.  For example, to add a chart, in the **Add Component** dialog box, select values for **Record Type**, **View**, and **Chart**, and then select **Add** to add the chart to the dashboard.  
  
6.  When you are finished adding components to your dashboard, select **Save** and then **Publish**.  
  
<a name="BKMK_editdashboard"></a>   
## Edit an existing dashboard  
  
1. Open solution explorer, and then select **Components** > **Dashboards**.  
  
2. Open (double-click) a dashboard, select one of the component areas, and then select **Edit Component**.  
  
3. In the **Set Properties** dialog box, make your changes. When you’re done, select **Set**.  
  
    For details on setting properties, see [Set properties for a chart or list included in a dashboard](../customize/set-properties-chart-list-included-dashboard.md).  
  
4. When you’ve completed your changes be sure to save them, and then publish them.  
  
   Additional system dashboards tasks you can perform include:  
  
-   Remove a list or chart from a dashboard  
  
-   Add a list or chart to a dashboard  
  
-   Set the default dashboard  
  
-   Use security roles to make a dashboard visible to just certain roles    
  
### See also  
[Set properties for a chart or list included in a dashboard](set-properties-chart-list-included-dashboard.md) <br />
[Configure interactive experience dashboards](configure-interactive-experience-dashboards.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]