---
title: "Customize quick view forms | MicrosoftDocs"
description: "This topic provides procedural steps to customize the quick view forms present in the Active Conversation page in Omnichannel for Customer Service."
ms.date: 12/30/2024
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
---
# Customize quick view forms

You can customize the quick view form in the section by navigating to the respective entities and quick view forms. The following are some of the relevant entities.

| Card         | Entity      | Quick View Form |
|------------------|-----------------|---------------------|
| Customer profile | Account > Forms | Customer profile    |
| Customer profile | Contact > Forms | Customer profile    |
| Issue snapshot   | Case > Forms    | Issue Snapshot      |
| Recent cases     | Account > Forms | Cases for customer |
| Recent cases     | Contact > Forms | Cases for customer |
||||

The following procedure shows how to modify the **Customer profile** quick view form of the **Account** entity. The process is similar for other forms that are listed in the preceding table.

1.  Sign in to the Dynamics 365 instance.

2.  Go to **Settings** > **Customization** > **Customize the system**.

3.  Expand **Components** > **Entities** > **Account**, and select **Forms**.

4.  Select **Customer profile**, which is of the type quick view form.

5.  In the form, select the section that you want to customize, such as add a field, and then in the **Field Explorer** pane, double-click the field you want to add to the form. For example, double-click the **Address 1: Address Type** field from the **Field Explorer** pane. The field is added to the section.

6.  Select **Save**, and then select **Publish**.

> [!TIP]
> To customize a quick view form, see [Edit a quick view form](/power-apps/maker/model-driven-apps/create-edit-quick-view-forms#edit-a-quick-view-form).


### Related information

[Omnichannel system customizers](omnichannel-customizer.md)  
[Customize Active Conversation form](customize-customer-summary.md)   


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
