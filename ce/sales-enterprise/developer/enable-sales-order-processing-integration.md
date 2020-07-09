---
title: "Enable sales order processing integration (Dynamics 365 Sales) | MicrosoftDocs"
description: 
ms.date: 07/09/2020
ms.service: 
  - dynamics-365-sales
ms.custom: 
  - dyn365-sales
ms.topic: get-started-article
author: susikka
ms.author: susikka
manager: shujoshi
ms.reviewer: susikka
---
# Enable sales order processing integration

Sales order processing integration makes it convenient to connect Dynamics 365 Sales with an external back-office order processing application. It allows a sales order created on Dynamics 365 Sales to be submitted, upon which the order can be synced to an external order processing application where the lifecycle of the order continues. A submitted order is locked for editing on Dynamics 365 Sales except if submitted by an integration user (to sync changes from the external order processing system to Dynamics 365 Sales). 

By default, sales order processing is turned off. When sales order processing is turned off, Dynamics 365 Sales allows invoices to be created from orders. For more information, see [Create an invoice from an order](../create-edit-invoice-sales.md). 

> [!NOTE]
> Price computation can be triggered by Dynamics 365 Sales only if the sales entities, like Opportunity, Quote, Sales order, and Invoice, are editable.

## Enable sales order processing integration

You can enable sales order processing integration by setting the value of the [IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) attribute on the [Organization entity](../../customerengagement/on-premises/developer/entities/organization.md) to Yes (1).

## What happens when sales order processing is turned on?

When sales order processing is turned on:  

- The **Create Invoice** button is not shown on the command bar of the Order records. 

- Order records will support a Submit order button. Upon submitting an order, the order status is marked as `Submitted`. The order is made read-only except if created by an integration user. For more information about the `IsIntegrationUser` attribute, see [IsIntegrationUser attribute](../../customerengagement/on-premises/developer/entities/systemuser.md#BKMK_IsIntegrationUser) on the [SystemUser entity](../../customerengagement/on-premises/developer/entities/systemuser.md).

The following table lists the conditions to be satisfied before Dynamics 365 Sales executes price computation for various entities.

|Entity name|Create|Update|Delete|Recalculate|
|------|------|------|------|------|
|Opportunity|Calculate always|Calculate always|NA|Calculate always|
|Quote|Calculate always|Calculate always|NA|Calculate always|
|Sales order|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and the signed-in user is an integration user|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and sales order is in submitted state or the signed-in user is an integration user|NA|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and the sales order is in submitted state|
|Invoice|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and the signed-in user is an integration user|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and the signed-in user is an integration user|NA|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and the signed-in user is an integration user|
|Opportunity product|Calculate always|Calculate always|Calculate always|NA|
|Quote product|Calculate always|Calculate always|Calculate always|NA|
|Sales order product|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and the signed-in user is an integration user or sales order is in submitted state|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and the signed-in user is an integration user or sales order is in submitted state|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and the signed-in user is an integration user|NA|
|Invoice product|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and the signed-in user is an integration user|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and the signed-in user is an integration user|Calculation skips if -<br />[IsSOPIntegrationEnabled](../../customerengagement/on-premises/developer/entities/organization.md#BKMK_IsSOPIntegrationEnabled) flag is set to Yes(1) and the signed-in user is an integration user|NA|

## Turn off the Sales Order Processing setting

Follow the steps given below to turn off the Sales Order Processing setting.

1. Go to **Sales Hub** and then select **App Settings**.
2. Select **General/Overview** and then select **Back Office Order Processing Integration**.
3. Select **Manage** and change the toggle to **Off**.

> [!NOTE]
> The setting can only be turned off if it is already enabled. Once turned off, the setting will not be displayed in UI.

## See also

[Organization entity reference](../../customerengagement/on-premises/developer/entities/organization.md)<br />
[System user entity reference](../../customerengagement/on-premises/developer/entities/systemuser.md)<br />
[Quote, order, and invoice entities](../../customerengagement/on-premises/developer/quote-order-invoice-entities.md)
