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

## Entity: Opportunity

**Question**:<br>When can I edit the **Est.Revenue** value in the **Opportunity** form?

**Answer**:<br>To edit the value of estimated **Revenue** in the **Opportunity** form, the **Revenue** must be configured as **User Provided** and the opportunity must be in an **Open** state. 

   > [!div class="mx-imgBorder"]
   > ![Edit estimated revenue](media/faqs-est-revenue.png "Edit estimated revenue")

 
## Entities: Opportunity, Quote, Invoice, and Order



<!--from editor: We define an "Important" alert as being "Information that the user needs to know to correctly perform a task." Do you agree that this alert falls into that category, or would it instead be a "Note" ("Additional, 'neutral' information, offered as an aside — 'nice to know' details")?
Also, does the alert apply to more entities than the ones mentioned? Are they "such as"?--> 


> [!IMPORTANT]
> In this section, we use the entity **Opportunity** to frame the questions. However, these questions are true for other entities— **Quote**, **Invoice**, and **Order**.

**Question**:<br>Why does any view other than **Opportunity Product Inline Edit View** lose the inline editable functionality in Web Client if it’s been selected for the **Opportunity Product** subgrid in the **Opportunity** form?

**Answer**:<br>This is known and by-design behavior in Web Client. However, this behavior is changed in Unified Interface. We recommend that you use Unified Interface to experience the inline edit view. To verify if a grid is editable, go to **Grid control properties**.

   > [!div class="mx-imgBorder"]
   > ![Properties settings for grid control](media/faqs-grid-control-properties.png "Properties settings for grid control")

   > [!NOTE]
   > - In Unified Interface, the behavior of the grid columns **Price Per Unit** and **Quantity** as editable or non-editable is independent of the view that is selected.  
   > - An editable grid doesn’t guarantee that all columns are editable; it depends on the **Pricing**.

## Entities: Opportunity Product, Quote Product, Order Product, and Invoice Product 



<!--from editor: Same questions about this alert as above.-->


> [!IMPORTANT]
> In this section, we use the entity **Opportunity Product** to frame the questions. However, these questions are true for other entities—**Quote Product**, **Order Product**, and **Invoice Product**.

**Question**:<br>How do you configure the value of the default **Pricing** to **Override Price** on the **Opportunity Product** form?

**Answer**:<br>To configure the value of the default **Pricing** as **Override Price** in the **Opportunity Product** form: 
1. Go to **Settings** > **Customizations** > **Customize the System**.
2. Select **Entities** > **Opportunity Product** > **Fields**.
3. Select the **ispriceoverridden** field and configure the **Default Value** to **Override Price**.
4. Save and publish the customizations.
 
## Entities: Order and Invoice


<!--from editor: Same questions for this alert as for the previous ones.-->


> [!IMPORTANT]
> In this section, we use the entity **Order** to frame the questions. However, these questions are true for **Invoice** also.

**Question**:<br>How can I change the default value for the **Prices Locked** field in the **Order** form?

**Answer**:<br>You can change the default value for the **Prices Locked** field in the **Order** form through customizations or the inline editable grid:
- **Through customizations**:
    1. Go to **Settings** > **Customizations** > **Customize the System**.
    2. Select **Entities** > **Order** > **Fields**.
    3. Select the **ispricelocked** field and configure the **Default Value** to **No**.
    4. Save and publish the customizations.
- **Through inline editable grid**:<br>
    Select the **Lock** icon on the editable grid and change the value of the **Prices Locked** field.

**Question**:<br>What does the **Prices Locked** (ispricelocked) field mean on the **Order** form and how does this field value impact the **Price Per Unit** column in the **Products** grid?

**Answer**:<br>The **Prices Locked** (ispricelocked) field controls the prices specified on the **Order** form and locks them from any further updates.<br>


<!--from editor: In the following sentence, is it supposed to be "... Order product form" instead of "from"?-->


These tables define the behavior of **PricePerUnit** in the **Products** subgrid and **Order** product from:<br> 

**For existing product**:
 
|Configuration| In editable grid – **PricePerUnit** column value| In non-editable grid – **PricePerUnit** column value| **Order** product form|
|-------------|-------------|-------------|-------------|
|**Prices Locked** is Yes|Non-editable|Non-editable|Non-editable|
|**Prices Locked** is No and **Pricing** is Override Price|Editable|Non-editable|Editable|
|**Prices Locked** is No and **Pricing** is Use Default|Non-editable|Non-editable|Non-editable|

**For new product**:

|Configuration| In editable grid – **PricePerUnit** column value| In non-editable grid – **PricePerUnit** column value| **Order** product form|
|-------------|-------------|-------------|-------------|
|**Prices Locked** is Yes|Non-editable|Non-editable|Non-editable|
|**Prices Locked** is No|Editable|Non-editable|Editable|
   
**Question**:<br>What is the result of changing the product price in **Pricelist** on the **PricePerUnit** of the **Order** product form?

**Answer**:<br>The following table defines the effect of changing the product price in **Pricelist** on the **PricePerUnit** of the **Order** product form:

|Entity state|IsPriceLocked|Pricing|Is the value of **PricePerUnit** on the **Order** product form changed?|
|------------|-------------|-------|----------------------------------------------------------------------|
|Editable|Yes|Default or Override|No|
|Editable|No|Default|Yes|
|Editable|No|Override|No|
|ReadOnly|Yes or No|Default or Override|No|
