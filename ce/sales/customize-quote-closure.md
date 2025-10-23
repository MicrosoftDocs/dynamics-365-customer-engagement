---
title: Customize the quote closure experience
description: A quote can be closed when it's lost, canceled, or revised. You can customize this experience to suit your organization needs.
ms.date: 11/18/2024
ms.topic: reference
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
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

As an administrator, you can customize the following aspects of quote closure experience to enable your sellers to close quotes quickly and efficiently:

- Change the default value of the **Create a revised quote** field to **No** in the Quote Close dialog to avoid creating unwanted revisions.
- Add command buttons to quickly close a quote without opening the Quote Close dialog.

Use [ribbon customizations](/power-apps/developer/model-driven-apps/customize-commands-ribbon) to customize these quote closure experience.

## Change the default value for creating a revised quote

When your sellers close a quote in Dynamics 365, they can choose to create a revised quote based on the original one. By default, this option is turned on in the Quote Close dialog box. However, you might want to turn it off to avoid creating unwanted revisions. To do this, you need to edit the code for the ribbon definition of the quote entity.

The ribbon definition is an XML file that controls the appearance and behavior of the ribbon buttons and menus. You can access it by downloading the [default ribbon data](/power-apps/developer/model-driven-apps/export-ribbon-definitions#access-the-default-ribbon-data). In the `quoteRibbon.xml` file, find the `closeQuote` function, which is triggered when you click the **Close Quote** button. This function has a boolean parameter that sets the default value for creating a revised quote. To change the default value to **No**, you need to change the value of this parameter from **true** to **false**. The following code snippet shows how to do this:

```xml
<CommandDefinition Id="Mscrm.Form.quote.CloseQuote">
    <EnableRules>
        <EnableRule Id="Mscrm.QuoteIsActive" />
    </EnableRules>
    <DisplayRules />
    <Actions>
        <JavaScriptFunction FunctionName="Sales.QuoteRibbonActions.Instance.closeQuote" Library="$webresource:Sales/_static/SFA/quotes/QuoteRibbonActions.js">
            <BoolParameter Value="true" /> <!-- Change this value from true to false -->
        </JavaScriptFunction>
    </Actions>
</CommandDefinition>
```

Make sure that the above definition is part of your entity customization solution. After you save and publish the changes, the default value for creating a revised quote in the Quote Close dialog box will be **No**. Sellers can still create a revised quote manually by selecting **Yes** in the dialog box.

## Add quick close quote button to the command bar

By default, when your sellers close a quote, the Quote Close dialog box opens for them to enter additional information. As an administrator, you can customize this experience by adding quick quote close buttons that will let your sellers close quotes with just a click.  

You can add multiple buttons to enable different behaviors. For example, you can add a button to close the quote as lost and create a revision and another button to close the quote as canceled and close the opportunity. The following screenshot is an example of how the quick quote close buttons can be implemented:

:::image type="content" source="media/quick-quote-close-example.png" alt-text="Screenshot of the quick quote close buttons on the command bar.":::

You can add these buttons to the command bar using [ribbon customizations](/power-apps/developer/model-driven-apps/customize-commands-ribbon).  

To add a button, define a new custom action in the quote ribbon customization and use the `Sales.QuoteRibbonActions.Instance.quickCloseQuoteWithoutDialog` javascript function from the  
`QuoteRibbonActions.js` file for its command action.

> [!IMPORTANT]
> All these parameters are mandatory and must be passed in the given order. If you miss any any of these parameters, the button will not work.

- **IntParameter (Status Reason)**: Use the IntParameter to specify the reason for quote closure. <br> **Allowed values**: 5 for Lost, 6 for Cancelled, 7 for Revise

- **BoolParameter (Create Revision)**: Use the first BoolParameter to specify whether you want to create a revised quote. <br> **Allowed values**: true,  false  
- **BoolParameter (Close Opportunity)**: Use the second BoolParameter to specify whether to close the associated opportunity. <br> **Allowed values**: true,  false  

The following code snippet includes a sample command definition to close the quote as lost and create a revision:

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


## Related information

- [Customize commands and the ribbon](/power-apps/developer/model-driven-apps/customize-commands-ribbon)
- [Export ribbon definitions](/power-apps/developer/model-driven-apps/export-ribbon-definitions)
- [Customize the command bar using command designer](/power-apps/maker/model-driven-apps/use-command-designer)