---
title: "Use the solution explorer in Dynamics 365 Customer Engagement (on-premises)"
description: "Learn how to use the solution explorer to create or customize apps. Get guidance on customizing the individual components found in the solution explorer."
ms.custom: 
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
author: Mattp123
ms.assetid: 72bacfbb-96a3-4daa-88ff-11bdaaac9a3d
caps.latest.revision: 57
ms.author: matp
search.audienceType: 
  - customizer

---
# Use the solution explorer to customize components
[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Use solutions in Power Apps](/powerapps/maker/common-data-service/use-solution-explorer)

Within the solution explorer you can navigate through a hierarchy of nodes using the navigation pane on the left side as shown in the following screenshot:  
  
 ![Default solution with entities collapsed.](../customize/media/crm-itpro-cust-defaultsolutionentitiescollapsed.PNG "Default solution with entities collapsed")  
  
> [!NOTE]
>  Use your mouse and keyboard when working with customization tools in the solution explorer. This part of the application isn’t optimized for touch.  
  
 As you select each node, you can see a list of the solution components. The actions available in the command bar will change depending on the context of the node you have selected and if the solution is the default solution or a managed solution. With unmanaged solutions that are not the default solution, you can use the **Add Existing** command to bring in solution components that aren’t already in the solution.  
  
With managed solutions there will be no commands available and you’ll see the message:  
  
> [!NOTE]
> You can’t directly edit the components within a managed solution. If the managed properties for solution components are set to allow customizations, you can edit them in the Customizations area or from another unmanaged solution.          
  
 You’ll need to locate the solution component in the default solution and try to edit it there or add it to another unmanaged solution that you’ve created. The solution component might not be customizable. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Managed properties](solutions-overview.md#managed-properties)
  
 Many of the customizations you’ll want to do will involve entities. You can expand the **Entities** node to show a list of all the entities in the system that can be customized in some way. You can further expand each entity to see the solutions components that are part of the entity as shown with the account entity in the following screenshot:  
  
 ![Default Solution showing expanded account entity.](../customize/media/crm-itpro-cust-defaultsolution.PNG "Default Solution showing expanded account entity")  
  
 For details about customizing the individual solution components found in the solution explorer, see the following topics:  
  
-   For entity, entity relationships, field and message customizations, see [Metadata](create-edit-metadata.md).  
  
-   For entity forms see [Forms](create-design-forms.md).  
  
-   For processes, see [Processes](guide-staff-through-common-tasks-processes.md).  
  
-   For business rules, see [Business Rules](create-business-rules-recommendations-apply-logic-form.md).  


### See also
[Solutions overview](solutions-overview.md)

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
