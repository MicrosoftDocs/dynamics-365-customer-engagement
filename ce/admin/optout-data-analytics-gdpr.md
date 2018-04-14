---
title: "Opt out of data analytics (GDPR) (Dynamics 365 Customer Engagement) | Microsoft Docs  "
description: "Opt out to ensure that no analytics is performed on your data when using Embedded Intelligence."
keywords: "GDPR; data protection; privacy; embedded intelligence"
ms.date: 04/08/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 6f86a039-15cc-46aa-b6fb-8dd8260de0ba
author: KumarVivek
ms.author: kvivek
manager: kvivek
---

# Opt out of data analytics (GDPR)

Applies to Dynamics 365 (online), version 9.0.2

A new boolean field or attribute called **msdyn_gdproptout** (display name: **GDPR Optout**) is added to the Contact, Lead, and SystemUser entities that enables you to specify whether analytics will be performed on the entity record's data.

- Setting the **GDPR Optout** field to "yes/true" will prohibit any analytics to be performed on the entity record's data.
- Setting the **GDPR Optout** field to "no/false" will allow analytics to be performed on the entity record's data.

## Customizing entity forms to display GDPR Optout field

By default, the **GDPR Optout** field is not available on the Contact, Lead and SystemUser forms. You can customize the form to display the **GDPR Optout** field on these entity forms so that one can easily set an appropriate value in this field for a record. By default, the value is set to **No** (false) for this field when you create a new record.

![](media/gdpr-optout-field.png)

For information about adding field to a form, see [Add a field to a form](../customize/add-field-form.md)

#3 Programmatically updating the **msdyn_gdproptout** field 

You can also programmatically update the value of the **msdyn_gdproptout** field by using Web API or Organization service. For information about updating using:
- Web API, see [Update a single property value](../developer/webapi/update-delete-entities-using-web-api.md#update-a-single-property-value)
- Organization service, see [Use the early-bound entity classes for create, update, and delete](../developer/org-service/use-early-bound-entity-classes-create-update-delete.md) or [Use the Entity class for create, update and delete](../developer/org-service/use-entity-class-create-update-delete.md)