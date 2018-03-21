---
title: "Query and visualize hierarchical data (Dynamics 365 Customer Engagement) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "jimholtz"
ms.assetid: 0cf62817-5ff5-40bb-ad17-e1f6b0921720
caps.latest.revision: 42
ms.author: "rdubois"
manager: "brycho"
---
# Query and visualize hierarchically related data

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

You can get valuable business insights by visualizing hierarchically related data. The [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] hierarchical modelling and visualization capabilities give you a number of benefits:  
  
-   View and explore complex hierarchical information.  
  
-   View key performance indicators (KPIs) in the contextual view of a hierarchy.  
  
-   Visually analyze key information across the web and the tablets.  
  
For some entities, such as account and user, the visualizations are provided out-of-the-box. Other entities, including custom entities, can be enabled for a hierarchy and you can create the visualizations for them. Based on your needs, you can choose between using a tree view, which shows the entire hierarchy, or a tile view, which depicts a smaller portion of the hierarchy. Both views are shown side by side. You can explore a hierarchy by expanding and contracting a hierarchy tree. The same hierarchical settings for visualization are set once, but apply to both [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] and [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)]. In tablets, the visuals render in a modified format suitable for the smaller form factor. The customizable components required for hierarchical visualization are solution aware, therefore, they can be transported between organizations like any other customization. You can configure the attributes shown in the visualization by customizing a Quick Form using the form editor. There is no requirement to write code.  
  
<a name="BKMK_Querydata"></a>   
## Query hierarchical data  
 In [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], hierarchical data structures are supported by self-referential one-to-many (1:N) relationships of the related records. In the past, to view hierarchical data, you had to iteratively query for the related records. Presently, you can query the related data as a hierarchy, in one step. You’ll be able to query records using the **Under** and **Not Under** logic. The **Under** and **Not Under** hierarchical operators are exposed in Advanced Find and the workflow editor. For more information about how to use these operators, see [Configure workflow steps](../customize/configure-workflow-steps.md). For more information about Advanced Find, see [Create, edit, or save an Advanced Find search](../basics/save-advanced-find-search.md)  
  
 The following examples illustrate various scenarios for querying hierarchies:  
  
 Query account hierarchy  
  
 ![Query accounts in the account hierarchy](../customize/media/query-accounts.png "Query accounts in the account hierarchy")  
  
 Query account hierarchy, including related activities  
  
 ![Query account's related activities](../customize/media/query-account-related-activities.png "Query account's related activities")  
  
 Query account hierarchy, including related opportunities  
  
 ![Query account's related opportunities](../customize/media/query-account-related-opportunities.png "Query account's related opportunities")  
  
 To query the data as a hierarchy, you must set one of the entity’s one-to-many (1:N) self-referential relationships as hierarchical. To turn the hierarchy on:  
  
1. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
2.  Choose **Customize your system** > **Components**.  
  
3.  Choose **Entity** > **1:N Relationships**, then choose a (1:N) relationship and in the **Relationship definition**, set **Hierarchical** to **Yes**.  
  
> [!NOTE]
> - Some of the out-of the-box (1:N) relationships can’t be customized. This will prevent you from setting those relationships as hierarchical.  
> - You can specify a hierarchical relationship for the system self-referential relationships. This includes the 1:N self-referential relationships of system type,  such as the "contact_master_contact" relationship.  
  
<a name="BKMK_Visualizedata"></a>   
## Visualize hierarchical data  
 The system entities that have visualizations available out-of-the-box include `Account`, `Position`, `Product`, and `User`. In the grid view of these entities, you can see the icon depicting the hierarchy chart, to the left of the record name. The hierarchy icon isn’t present for all records by default. The icon is shown for the records that have a parent record, a child record, or both.  
  
 ![Active accounts](../customize/media/cust-hs-active-account.png "Active accounts")  
  
 If you select the hierarchy icon, you can view the hierarchy, with the tree view on the left and the tile view on the right, as shown below:  
  
 ![Account tree and tile view in Dynamics 365](../customize/media/hierachy-security-accounts-tile-view.png "Account tree and tile view in Dynamics 365")  
  
 A few other out-of the-box system entities can be enabled for a hierarchy. These entities include `Case`, `Contact`, `Opportunity`, `Order`, `Quote`, `Campaign`, and `Team`. All custom entities can be enabled for a hierarchy.  
  
> [!TIP]
>  If an entity can be enabled for a hierarchy:  
>   
>  1. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
> 2.  Choose **Customize your system** > **Components** > **Entity**. You will see the selection called **Hierarchy Settings**. The entities that can’t be enabled for a hierarchy don’t have this selection, with the exception of the Sales Territory entity. Although **Hierarchy Settings** appears for the Sales Territory entity, the entity can’t be enabled for a hierarchy.  
  
 Important things to remember when you create visualizations:  
  
-   Only one (1: N) self-referential relationship per entity can be set as hierarchical. In this relationship the primary entity and the related entity must be of the same type, such as account_parent_account or new_new_widget_new_widget.  
  
-   Presently, a hierarchy or visualization is based on one entity only. You can depict the account hierarchy showing accounts at multiple levels, but you can’t show accounts and contacts in the same hierarchy visualization.  
  
-   Maximum number of fields that can be displayed in a tile is four. If you add more fields to the Quick Form that is used for the tile view, only the first four fields will be displayed.  
  
### Visualization example  
 Let’s look at an example of creating the visualization for a custom entity. We created a custom entity called new_Widget, created a (1:N) self-referential relationship **new_new_widget_new_widget** and marked it as hierarchical, as shown here.  
  
 ![Widget relationship definition](../customize/media/widget-relationship-definition.png "Widget relationship definition")  
  
 Next, in the **Hierarchy Settings** grid view, we selected the **new_new_widget_new_widget** hierarchical relationship. In the form, we filled in the required fields. If you haven’t yet marked the (1:N) relationship as hierarchical, the link on the form will take you back to the relationship definition form, where you can mark the relationship as hierarchical.  
  
 ![Hierarchy settings](../customize/media/hierarchy-settings.png "Hierarchy settings")  
  
 For the **Quick View Form**, we created a Quick Form called **Widget Hierarchy Tile Form**. In this form, we added four fields to display in each tile.  
  
 ![Create quick form for widget](../customize/media/create-quickf-orm.png "Create quick form for widget")  
  
 After we completed the setup, we created two records: Standard Widget and Premium Widget. After making the Premium Widget a parent of the Standard Widget by using the lookup field, the new_Widget grid view depicted the hierarchy icons, as shown below:  
  
 ![Widget's hierarchy grid](../customize/media/widget-hierarchy-grid.png "Widget's hierarchy grid")  
  
> [!TIP]
>  The hierarchy icons don’t appear in the record grid view until the records are paired in the parent – child relationship.  
  
 Choosing the hierarchy icon displays the new_Widget hierarchy with the tree view on the left and the tile view on the right, showing two records. Each tile contains four fields that we provided in the **Widget Hierarchy Tile Form**.  
  
 ![Widget's tree and tiles views](../customize/media/widget-tree-tiles.png "Widget's tree and tiles views")  
  
### See also  
 [Video: Hierarchical Security Modelling](http://www.youtube.com/watch?v=kx5So32DrCo&index=10&list=PLC3591A8FE4ADBE07)   
 [Video: Hierarchy Visualization](http://www.youtube.com/watch?v=_dGBE6icLNw&index=9&list=PLC3591A8FE4ADBE07)
