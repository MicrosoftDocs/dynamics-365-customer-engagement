---
title: "Customize quick view forms | MicrosoftDocs"
description: "Learn how to customize the quick view forms present in the Customer Summary page."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 07/01/2019
ms.service: 
  - dynamics-365-customerservice
ms.topic: article
---
# Customize quick view forms

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

You customize the quick view form in the section by navigating to the respective entities and quick view forms.

> [!NOTE]
> This procedure shows how to modify the **Customer Profile** section in the Customer summary form of the **Conversation** entity. However, the process is similar for other forms in the sections.

1.  Sign in to the Common Data Service platform.

2.  Go to **Settings** > **Customization** > **Customize the system**.

3.  Expand **Components** > **Entities** > **Account** and select **Forms**.

4.  Select **Customer summary**, which is of the form type **Quick View Form**.

5.  In the form, select the section for which you want to add a field, and then in the **Field Explorer** pane, double-click the field you want to add to the form. For example, double-click the **Address 1: Address Type** field from the **Field Explorer** pane. The field is added to the section.

 > [!div class=mx-imgBorder]
 > ![Customize quick view form](../media/oc-crm-add-remove-fields-customer360.png "Customize quick view form")  

6.  Select **Save** and then select **Publish**.

> [!TIP]
> To edit a quick view form, see [Edit a quick view form](https://docs.microsoft.com/dynamics365/customer-engagement/customize/create-edit-quick-view-forms#edit-a-quick-view-form)  

You can also use the previous procedure to add or remove fields in other sections. In step 3, select the entity that is shown in the following table, and then, in step 4, select the quick view form that is shown. Then follow steps 5 through 6.

| **Card**         | **Entity**         | **Quick View Form** |
|------------------|--------------------|----------------------|
| Customer profile | Account > Forms | Customer summary         |
| Customer profile | Contact > Forms | Customer summary         |
| Issue snapshot   | Case > Forms    | Issue Snapshot       |
| Recent cases     | Account > Forms |  Cases for customer |
| Recent cases     | Contact > Forms |  Cases for customer |

> [!div class="nextstepaction"]
> [Next topic: Customize the session form](customize-session-form.md)

## See also

- [Omnichannelsystem customizers](omnichannel-customizer.md)
- [Customize Customer summary form](customize-customer-summary.md)
- [Configure agent and supervisor configurations in Unified Service Desk](create-agent-supervisor-configurations-unified-service-desk.md)
- [Configure notification (Screen pop) for agents](configure-notification-screen-pop-agents.md)
