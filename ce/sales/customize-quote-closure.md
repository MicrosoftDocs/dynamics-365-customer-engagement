---
title: Customize the quote closure experience
description: A quote can be closed when it's lost, canceled, or revised. You can customize this experience to suit your organization needs.
ms.date: 09/20/2023
ms.topic: reference
author: lavanyakr01
ms.author: lavanyakr
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-quote
  - D365-Entity-salesorder
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---

# Customize the quote closure experience

As an administrator, you can customize the following aspects of quote closure experience to close quotes quickly and efficiently:

- Ability to change the default value of the **Create a revised quote** field in the Quote Close dialog.
- Ability to quickly close a quote without opening the Quote Close dialog.

Use [ribbon customizations](/power-apps/developer/model-driven-apps/customize-commands-ribbon) to do these changes.

## Set the default value for the Create a revised quote field

By default, the **Create a revised quote** field in the Quote Close dialog box is set to **Yes**. This may result in accidental creation of revised quotes, if the seller forgets to change the value. You can change this default value to **No** by setting the boolean parameter in the `closeQuote` function of `quoteRibbon` ribbon definition. The following code snippet shows how to set the default value to **No** in your ribbon definition file:

```xml
<Actions>
    <>
```

To download the latest ribbon definition file, see [Access the default ribbon data](/power-apps/developer/model-driven-apps/export-ribbon-definitions#access-the-default-ribbon-data)

## Add quick quote close button to the command bar

By default, when your sellers close a quote, the Quote Close dialog box opens for them to enter additional information. As an administrator, you can customize this experience by adding quick quote close buttons that will let your sellers close quotes with just a click of a button. You can add these buttons to the command bar using ribbon customizations.  

You can define a new custom action in the quote entity ribbon definition to add a new button for the quick close functionality and use the `quickQuoteCloseWithoutDialog` javascript method as the command action method for it. You can add multiple buttons to enable different behaviors by passing different parameters to this function. For example, you can add a button to close the quote as lost and create a revision and another button to close the quote as lost and close the opportunity. Use the following parameters to customize the button behavior: 

- **StatusReason**: Specifies the reason for the closure. <br> **Allowed values**: 5 for Lost, 6 for Cancelled, 7 for Revise

- **CreateRevise**: Specifies whether you want to revise the quote. <br> **Allowed values**: true,  false
- **CloseOpty**: Specifies whether to close the associated opportunity. <br> **Allowed values**: true,  false 


