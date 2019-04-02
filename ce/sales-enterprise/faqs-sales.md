---
title: "Frequently asked questions (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Frequently asked questions for Dynamics 365 for Sales"
keywords: "sales, faqs, best practice, frequently asked questions"
ms.date: 04/01/2019
ms.service:
  - dynamics-365-sales
ms.custom:
  - "dyn365-sales"
ms.topic: article
applies_to:
  - "Dynamics 365 for Customer Engagement"
  - "Dynamics 365 for Customer Engagement apps version 9.1"
ms.assetid: 11857a6e-3ced-42b5-980b-081c2c4d4774
author: udaykirang
ms.author: udag
manager: shubhadaj

---

# Frequently asked questions

## Entities: Opportunity, Quote, Invoice, and Order

> [!IMPORTANT]
> In the section we use the entity **Opportunity** to frame the questions. However, these questions are true for other entities - **Quote**, **Invoice**, and **Order**.

**Question**:<br>Why any view other than **Opportunity Product Inline Edit View** loses the inline editable functionality in WebClient if it’s been selected for **Opportunity Product** sub grid in the **Opportunity** form?

**Answer**:<br>This behavior is known and is by design in Web Client. However, this behavior is changed through Unified Interface. You can  

**Question**:<br>How to configure the value of default **Pricing** to **Override Price** on **Opportunity Product** form?

**Answer**:<br>To configure the value of default **Pricing** as **Override Price** in **Opportunity Product** form: 
1. Go to **Settings** > **Customizations** > **Customize the System**.
2. Select **Entities** > **Opportunity Product** > **Fields**.
3. Select **ispriceoverridden** field and configure the **Default Value** to **Override Price**.
4. Save and publish the customizations.
 
**Question**:<br>When can I edit the **Est.Revenue** value in **Opportunity** form?

**Answer**:<br>To edit the value of estimated **Revenue** in **Opportunity** form , the **Revenue** must configured as **User Provided** and the opportunity must be in **Open** state. 

   > [!div class="mx-imgBorder"]
   > ![Edit estimated revenue](media/faqs-est-revenue.png "Edit estimated revenue")

## Entities: Order and Invoice

> [!IMPORTANT]
> In the section we use the entity **Order** to frame the questions. However, these questions are true for **Invoice** also.

**Question**:<br>How can I change the default value for **Prices Locked** field in **Order** form?

**Answer**:<br>You can change the default value for **Prices Locked** field in **Order** form through customizations or inline editable grid:
- **Through customizations**:
    1. Go to **Settings** > **Customizations** > **Customize the System**.
    2. Select **Entities** > **Order** > **Fields**.
    3. Select **ispricelocked** field and configure the **Default Value** to **No**.
    4. Save and publish the customizations.
- **Through inline editable grid**:<br>
    Select the Lock icon on editable grid and you can change the value of **Prices Locked** field.

**Question**:<br>What is the **Prices Locked** (ispricelocked) field mean on the **Order** form and how this value of field impacts the **Price Per Unit** column in the **Products** grid?

**Answer**:<br>The **Prices Locked** (ispricelocked) field controls the prices specified on the **Order** are locked from any further updates.<br>
Behavior of **PricePerUnit** in the **Products** subgrid and **Order** product from:<br> 
- **For existing product**:
 
|Configuration| In editable grid – **PricePerUnit** column value| In non-editable grid – **PricePerUnit** column value| **Order** product form|
|-------------|-------------|-------------|-------------|
|**Prices Locked** is Yes|Non-Editable|Non-Editable|Non-Editable|
|**Prices Locked** is No and **Pricing** is Override Price|Editable|Non-Editable|Editable|
|**Prices Locked** is No and **Pricing** is Use Default|Non-Editable|Non-Editable|Non-Editable|

- **For new product**:

|Configuration| In editable grid – **PricePerUnit** column value| In non-editable grid – **PricePerUnit** column value| **Order** product form|
|-------------|-------------|-------------|-------------|
|**Prices Locked** is Yes|Non-Editable|Non-Editable|Non-Editable|
|**Prices Locked** is No|Editable|Non-Editable|Editable|
   
**Question**:<br>What is the result of changing product price in **Pricelist** on the **PricePerUnit** of **Order** product form?

**Answer**:<br>The following table defines the effect of changing product price in **Pricelist** on the **PricePerUnit** of **Order** product form:

|Entity State|IsPriceLocked|Pricing|Is the value of **PricePerUnit** on the **Order** product form change?|
|------------|-------------|-------|----------------------------------------------------------------------|
|Editable|Yes|Default or Override|No|
|-|No|Default|Yes|
|-|-|Override|No|
|ReadOnly|Yes or No|Default or Override|No|