---
title: "Access a view definition with Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
description: Learn how to access entity views
ms.custom: 
ms.date: 08/08/2018
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
author: Mattp123
ms.assetid: 034c8bef-0d1c-4ef9-8da7-f81343c4553a
caps.latest.revision: 25
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---
# Access a view definition in Dynamics 365 Customer Engagement (on-premises)

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Access a model-driven app view definition in Power Apps](/powerapps/maker/model-driven-apps/accessing-view-definitions)

<a name="BKMK_AccessingViewDefinitions"></a>   

 There are several ways you can access view definitions in Dynamics 365 Customer Engagement (on-premises). On any list view for an entity, in the command bar you will find the following commands after you click or tap the ellipsis (![More Commands button in Appointment Activity](../customize/media/more-commands.gif "More Commands button in Appointment Activity")) button:  
  
- **View**: Opens the definition of the current view in the default solution.  
  
- **New System View**: Opens a new window to create a new view for the current entity in the default solution.  
  
- **Customize Entity**: Takes you to the definition of the current entity in the default solution where you can then select **Views**.  
  
- **System Views**: Opens the same window as **Customize Entity**, except with **Views** selected.  
  
  Alternatively, you can navigate to the view definitions in the default solution by using the following steps:  
  
## Open a view  
  
1. Open solution explorer. In the Dynamics 365 Customer Engagement (on-premises) app, select **Settings** > **Settings** > **Customizations** > **Customize the system**.
  
2. Under **Components**, expand **Entities**, and then expand the entity you want.  
  
3. Click **Views**.  
  
4. Double-click the view you want to open.  
  
   This list of views has four filters you can use to find the views you want more easily:  
  
- **All Active Views**  
  
- **Active Public Views**  
  
- **Inactive Public Views**  
  
- **Active System-Defined Views**  
  
  If the entity that the view is associated with is part of an unmanaged solution, you can still create or edit views for that entity in the default solution. System views are associated with an entity and are not available as separate solution components. Unlike fields, views do not use a customization prefix in a unique name that should be consistent in a solution, so you do not need to create views in the context of a solution. 
 
### See also
[Create or edit views](create-edit-views.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]