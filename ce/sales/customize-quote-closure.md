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

## Change the default value for the Create a revised quote field

By default, the **Create a revised quote** field in the Quote Close dialog box is set to **Yes**. This may result in accidental creation of revised quotes, if the seller forgets to change the value. You can change this default value to **No** by setting the boolean parameter in the `closeQuote` function of `quoteRibbon` ribbon definition. The following code snippet shows the xml code to change the default value to **No**:

```xml
<Actions>
  <JavaScriptFunction FunctionName="Sales.QuoteRibbonActions.Instance.closeQuote" Library="$webresource:Sales/_static/sfa/quotes/QuoteRibbonActions.js">
  <BoolParameter Value="false" />
  </JavaScriptFunction>
</Actions>
```

To download the latest ribbon definition file, see [Access the default ribbon data](/power-apps/developer/model-driven-apps/export-ribbon-definitions#access-the-default-ribbon-data)

## Add quick quote close button to the command bar

By default, when your sellers close a quote, the Quote Close dialog box opens for them to enter additional information. As an administrator, you can customize this experience by adding quick quote close buttons that will let your sellers close quotes with just a click of a button. You can add multiple buttons to enable different behaviors by passing different parameters to this function. For example, you can add a button to close the quote as lost and create a revision and another button to close the quote as lost and close the opportunity. You can add these buttons to the command bar using ribbon customizations.  

To add a button, define a new command definition in the QuoteRibbonActions.js file and use the `Sales.QuoteRibbonActions.Instance quickCloseQuoteWithoutDialog` javascript function as the command action for it. Use the following parameters to customize the button behavior:  

> [!IMPORTANT]
> All these parameters are mandatory and must be passed in the given order. If you don't pass any of these parameters, the button will not work.


- **IntParameter (Status Reason)**: Use the IntParameter to specify the reason for quote closure. <br> **Allowed values**: 5 for Lost, 6 for Cancelled, 7 for Revise

- **BoolParameter (Create Revision)**: Use the first BoolParameter to specify whether you want to create a revised quote. <br> **Allowed values**: true,  false  
- **BoolParameter (Close Opportunity)**: Use the second BoolParameter to specify whether to close the associated opportunity. <br> **Allowed values**: true,  false  

The following code snippet shows how to add a button to close the quote as lost and create a revision:

```xml
<CommandDefinitions>
<CommandDefinition Id="new.quote.Command0.Command">
<EnableRules>
<EnableRule Id="new.quote.EnableRule0.EnableRule" />
</EnableRules>
<DisplayRules />
<Actions>
<JavaScriptFunction FunctionName="Sales.QuoteRibbonActions.Instance quickCloseQuoteWithoutDialog" Library="$webresource:Sales/_static/sfa/quotes/QuoteRibbonActions.js">
<IntParameter Value="5" />
<BoolParameter Value="true" />
<BoolParameter Value="false" />
</JavaScriptFunction>
</Actions>
</CommandDefinition>
</CommandDefinitions>
```


### See also

- [Customize commands and the ribbon](/power-apps/developer/model-driven-apps/customize-commands-ribbon)
- [Export ribbon definitions](/power-apps/developer/model-driven-apps/export-ribbon-definitions)
- [Customize the command bar using command designer](/power-apps/maker/model-driven-apps/use-command-designer)