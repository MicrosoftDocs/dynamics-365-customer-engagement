---
title: "Edit navigation in a form with Dynamics 365 Customer Engagement (on-premises)"
description: "Navigation within a form allows users to view lists of related records. In the form editor, you can override relationships or include navigation links."
ms.custom: 
ms.date: 11/09/2021
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
author: Mattp123
ms.assetid: 4c379202-9f0e-4003-a49c-efff53e7f79f
caps.latest.revision: 63
ms.author: matp
search.audienceType: 
  - customizer

---
# Change navigation within a form

Navigation within a form allows app users to view lists of related records. Each entity relationship has properties to control whether it should be shown. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Navigation pane item for primary entity](create-and-edit-1n-relationships.md#navigation-pane-item-for-primary-entity)  
  
Any entity relationships that are configured to be displayed can be overridden within the form editor. You can also include navigation links to display web resources or other web sites via form navigation.  
  
For step-by-step instructions, see [Create and edit entity relationships](create-edit-entity-relationships.md)  
  
To enable editing navigation for a form, from the form editor you must first select **Navigation** from the **Select** group on the **Home** tab. This enables the following form design components: 
1. The form navigation area on the left pane in the form designer.
1. The **Relationship Explorer** on the right pane in the form designer.

:::image type="content" source="media/enable-form-nav-editing.png" alt-text="Enable form navigation by selecting Navigation on the form designer ribbon":::

There are five groups in the navigation area on the left pane. You can drag them to reposition them and double-click them to change the label, but you can’t remove them. These groups will only display when there is something in them. So if you don’t want a group to appear, just don’t add anything to it.  

In the right pane, the **Relationship Explorer** lets you filter by 1:N (one-to-many) or N:N (many-to-many) relationships, or view all available relationships. The **Only show unused relationships checkbox** is disabled and selected. So you can only add each relationship one time.

To add a relationship from the **Relationship Explorer** just double-click it and it will be added below the currently selected relationship in the navigation area. Double-click a relationship in the navigation area and you can change the label on the **Display** tab. On the **Name** tab you can see information about the relationship. Use the **Edit** button to open the definition of the entity.  
  
<a name="BKMK_NavigationLinkProperties"></a>   
### Add a navigation link to a form

Use the **Navigation Link** button in the **Control** group of the **Insert** tab to add a link to a web resource or external URL.

:::image type="content" source="media/navigation-link.png" alt-text="Add navigation link to a form":::

Navigation links have the following properties:  
  
|Property|Description|  
|--------------|-----------------|  
|Name|**Required**: Text to display as a label.|  
|Icon|Use a 32x32 pixel web resource. Use a PNG image with a transparent background is recommended.|  
|Web Resource|Specify a web resource to display in the main pane of the form. More information: [Create or edit web resources to extend an app](create-edit-web-resources.md) |  
|External URL|Specify the URL of a page to display in the main pane of the form.|  

<a name="BKMK_PrivacyNotices"></a>   

## Privacy notices  
 [!INCLUDE[cc_privacy_crm_website_preview_control](../includes/cc-privacy-crm-website-preview-control.md)]    
  
 [!INCLUDE[cc_privacy_multimedia_control](../includes/cc-privacy-multimedia-control.md)]  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
