---
title: "Sort records in a view in Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
ms.custom: 
ms.date: 11/09/2018
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
author: Mattp123
ms.assetid: 25f5aa52-56dc-4be5-884e-9346616f665f
caps.latest.revision: 25
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---
# Sort records in a view

<a name="BKMK_ConfigureSorting"></a>    

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Sort records in a model-driven app view](/powerapps/maker/model-driven-apps/configure-sorting)
  
1.  When you create or edit the view, select **Configure Sorting**.  
  
2.  In the **Configure Sort Order** dialog box, in the **Sort By** list, select the column you want to sort, then select **Ascending Order** or **Descending Order**.  
  
3.  Select **OK** to close the **Configure Sort Order** dialog box.

    > [!IMPORTANT]
    > Grids in Unified Interface apps take the list of displayed columns from the underlying FetchXML of the view. If the FetchXML that is returned from the server does not have a column, then that column is not displayed. This is in contrast to the classic web application, where if a column is not present in FetchXML but is in LayoutXML, such a column is automatically added to the list of displayed columns. Unified Interface apps use OData directly with FetchXML to retrieve data from the server.

### See also
[Create or edit a view](create-edit-views.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]