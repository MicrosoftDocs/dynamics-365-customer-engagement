---
title: "Configure Link to conversation button in model-driven app entity form | MicrosoftDocs"
description: "Learn how to configure Link to conversation button in model-driven app form for agents using Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 10/25/2019
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Configure Link to conversation button in model-driven app entity form

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

This topic describes how you, as a system customizer, can configure the **Link to conversation** button in the model-driven app entity form for agents using Omnichannel for Customer Service app.

When an agent accepts a conversation request, and there is no record in Omnichannel for Customer Service linked to this conversation, the agent wants to search for a contact or account record and link the record to the conversation. As a system customizer, you need to configure the **Link to conversation** button in the model-driven app entity (contact, account or case) form so agents can link a record to the current conversation. After you link a record to the conversation, the **Customer summary** page loads and displays the record that you linked.

> [!Note]
> The Link to conversation button appears only in a session (context of a conversation) and not on the main forms.

To add the **Link to conversation** button in the model-driven app entity form, as a system customizer, you need to customize the ribbon (`<RibbonDiffXml>`) definition. The customization change definitions that you specify are applied at runtime when the ribbon is displayed in the application.

With latest release of Omnichannel for Customer Service base solutions, you get the web resources to add the **Link to conversation** button.

## Customize the entity ribbon to add Link to conversation button

To add the **Link to conversation** button, you need to customize the ribbon (`<RibbonDiffXml>`) of the entity. To do so, you will edit the ribbon in the **Form context** of the entity.

**Name of the web resource:** `msdyn_OmnichannelLinkCommand.js`

[Step 1: Export and edit the XML](#step-1-export-and-edit-the-xml)

[Step 2: Add command and define ribbon actions](#step-2-add-command-and-define-ribbon-actions)

[Step 3: Enable display rules](#step-3-enable-display-rules)

[Step 4: Import the ribbon](#step-4-import-the-ribbon)

## Step 1: Export and edit the XML

In this step, you need to export the ribbon and edit the `<RibbonDiffXml>`.

To learn more, see [Export, prepare to edit, and import the ribbon](/powerapps/developer/model-driven-apps/export-prepare-edit-import-ribbon).

## Step 2: Add command and define ribbon actions

Edit the XML to provide values for the parameters such as:

- Library
- FunctionName
- StringParameter Value
- Button

| Parameter name | Value | Comment |
|----------------------------|---------------------------------------|------------|
| `Library` | `$webresource:msdyn_OmnichannelLinkCommand.js` | |
| `FunctionName` | `OmniChannelPackage.OmnichannelLinkCommand.linkRecordToConversation` | |
| `StringParameter Value` | <ul> <li> `msdyn_account_msdyn_ocliveworkitem_Customer` </li> <li> `msdyn_incident_msdyn_ocliveworkitem` </li> <li> `msdyn_contact_msdyn_ocliveworkitem_Customer` </li></ul> | <ul> <li>Used for the Account entity </li> <li>Used for the Case entity </li> <li>Used for the Contact entity </li></ul> |

**Sample snippet**

```XML
<JavaScriptFunction FunctionName="OmniChannelPackage.OmnichannelLinkCommand.linkRecordToConversation" Library="$webresource:msdyn_OmnichannelLinkCommand.js">
<StringParameter Value="msdyn_account_msdyn_ocliveworkitem_Customer" />
</JavaScriptFunction>
```

### Sample XML for Account entity ribbon customization

```XML
<RibbonDiffXml>
  <CustomActions>
    <CustomAction Id="msdyn.account.LinkToConversation.Button.CustomAction" Location="Mscrm.Form.account.MainTab.Save.Controls._children" Sequence="57">
      <CommandUIDefinition>
        <Button Alt="$LocLabels:msdyn.account.LinkToConversation.Button.Alt" Command="msdyn.account.LinkToConversation.Command" Id="msdyn.account.LinkToConversation.Button" Image32by32="$webresource:msdyn_LinkToConversationCommandButtonIcon.png" Image16by16="$webresource:msdyn_LinkToConversationCommandButtonIcon.png" LabelText="$LocLabels:msdyn.account.LinkToConversation.Button.LabelText" Sequence="57" TemplateAlias="o1" ToolTipTitle="$LocLabels:msdyn.account.LinkToConversation.Button.ToolTipTitle" ToolTipDescription="$LocLabels:msdyn.account.LinkToConversation.Button.ToolTipDescription" />
      </CommandUIDefinition>
    </CustomAction>
  </CustomActions>
  <Templates>
    <RibbonTemplates Id="Mscrm.Templates"></RibbonTemplates>
  </Templates>
  <CommandDefinitions>
    <CommandDefinition Id="msdyn.account.LinkToConversation.Command">
      <EnableRules>
        <EnableRule Id="msdyn.account.EnableInConversationContext.EnableRule" />
      </EnableRules>
      <DisplayRules />
      <Actions>
        <JavaScriptFunction FunctionName="OmniChannelPackage.OmnichannelLinkCommand.linkRecordToConversation" Library="$webresource:msdyn_OmnichannelLinkCommand.js">
          <StringParameter Value="msdyn_account_msdyn_ocliveworkitem_Customer" />
        </JavaScriptFunction>
      </Actions>
    </CommandDefinition>
  </CommandDefinitions>
  <RuleDefinitions>
    <TabDisplayRules />
    <DisplayRules />
    <EnableRules>
      <EnableRule Id="msdyn.account.EnableInConversationContext.EnableRule">
        <CustomRule FunctionName="OmniChannelPackage.OmnichannelLinkCommand.shouldDisplayLinkCommand" Library="$webresource:msdyn_OmnichannelLinkCommand.js" Default="false" />
      </EnableRule>
    </EnableRules>
  </RuleDefinitions>
  <LocLabels>
    <LocLabel Id="msdyn.account.LinkToConversation.Button.Alt">
      <Titles>
        <Title description="Link to conversation" languagecode="1033" />
      </Titles>
    </LocLabel>
    <LocLabel Id="msdyn.account.LinkToConversation.Button.LabelText">
      <Titles>
        <Title description="Link to Conversation" languagecode="1033" />
      </Titles>
    </LocLabel>
    <LocLabel Id="msdyn.account.LinkToConversation.Button.ToolTipDescription">
      <Titles>
        <Title description="Link this record to the conversation" languagecode="1033" />
      </Titles>
    </LocLabel>
    <LocLabel Id="msdyn.account.LinkToConversation.Button.ToolTipTitle">
      <Titles>
        <Title description="Link to conversation" languagecode="1033" />
      </Titles>
    </LocLabel>
  </LocLabels>
</RibbonDiffXml>
```

### Sample XML for Case entity ribbon customization

```XML
<RibbonDiffXml>
  <CustomActions>
    <CustomAction Id="msdyn.incident.LinkToConversation.Button.CustomAction" Location="Mscrm.Form.incident.MainTab.Save.Controls._children" Sequence="45">
      <CommandUIDefinition>
        <Button Alt="$LocLabels:msdyn.incident.LinkToConversation.Button.Alt" Command="msdyn.incident.LinkToConversation.Command" Id="msdyn.incident.LinkToConversation.Button" Image32by32="$webresource:msdyn_LinkToConversationCommandButtonIcon.png" Image16by16="$webresource:msdyn_LinkToConversationCommandButtonIcon.png" LabelText="$LocLabels:msdyn.incident.LinkToConversation.Button.LabelText" Sequence="45" TemplateAlias="o1" ToolTipTitle="$LocLabels:msdyn.incident.LinkToConversation.Button.ToolTipTitle" ToolTipDescription="$LocLabels:msdyn.incident.LinkToConversation.Button.ToolTipDescription" />
      </CommandUIDefinition>
    </CustomAction>
  </CustomActions>
  <Templates>
    <RibbonTemplates Id="Mscrm.Templates"></RibbonTemplates>
  </Templates>
  <CommandDefinitions>
    <CommandDefinition Id="msdyn.incident.LinkToConversation.Command">
      <EnableRules>
        <EnableRule Id="msdyn.incident.EnableInConversationContext.EnableRule" />
      </EnableRules>
      <DisplayRules />
      <Actions>
        <JavaScriptFunction FunctionName="OmniChannelPackage.OmnichannelLinkCommand.linkRecordToConversation" Library="$webresource:msdyn_OmnichannelLinkCommand.js">
          <StringParameter Value="msdyn_incident_msdyn_ocliveworkitem" />
        </JavaScriptFunction>
      </Actions>
    </CommandDefinition>
  </CommandDefinitions>
  <RuleDefinitions>
    <TabDisplayRules />
    <DisplayRules />
    <EnableRules>
      <EnableRule Id="msdyn.incident.EnableInConversationContext.EnableRule">
        <CustomRule FunctionName="OmniChannelPackage.OmnichannelLinkCommand.shouldDisplayLinkCommand" Library="$webresource:msdyn_OmnichannelLinkCommand.js" />
      </EnableRule>
    </EnableRules>
  </RuleDefinitions>
  <LocLabels>
    <LocLabel Id="msdyn.incident.LinkToConversation.Button.Alt">
      <Titles>
        <Title description="Link to conversation" languagecode="1033" />
      </Titles>
    </LocLabel>
    <LocLabel Id="msdyn.incident.LinkToConversation.Button.LabelText">
      <Titles>
        <Title description="Link to Conversation" languagecode="1033" />
      </Titles>
    </LocLabel>
    <LocLabel Id="msdyn.incident.LinkToConversation.Button.ToolTipDescription">
      <Titles>
        <Title description="Link this record to the conversation" languagecode="1033" />
      </Titles>
    </LocLabel>
    <LocLabel Id="msdyn.incident.LinkToConversation.Button.ToolTipTitle">
      <Titles>
        <Title description="Link to conversation" languagecode="1033" />
      </Titles>
    </LocLabel>
  </LocLabels>
</RibbonDiffXml>
```
### Sample XML for Contact entity ribbon customization

```XML
<RibbonDiffXml>
  <CustomActions>
    <CustomAction Id="msdyn.contact.LinkToConversation.Button.CustomAction" Location="Mscrm.Form.contact.MainTab.Save.Controls._children" Sequence="53">
      <CommandUIDefinition>
        <Button Alt="$LocLabels:msdyn.contact.LinkToConversation.Button.Alt" Command="msdyn.contact.LinkToConversation.Button.Command" Id="msdyn.contact.LinkToConversation.Button" Image32by32="$webresource:msdyn_LinkToConversationCommandButtonIcon.png" Image16by16="$webresource:msdyn_LinkToConversationCommandButtonIcon.png" LabelText="$LocLabels:msdyn.contact.LinkToConversation.Button.LabelText" Sequence="53" TemplateAlias="o1" ToolTipTitle="$LocLabels:msdyn.contact.LinkToConversation.Button.ToolTipTitle" ToolTipDescription="$LocLabels:msdyn.contact.LinkToConversation.Button.ToolTipDescription" />
      </CommandUIDefinition>
    </CustomAction>
  </CustomActions>
  <Templates>
    <RibbonTemplates Id="Mscrm.Templates"></RibbonTemplates>
  </Templates>
  <CommandDefinitions>
    <CommandDefinition Id="msdyn.contact.LinkToConversation.Button.Command">
      <EnableRules>
        <EnableRule Id="msdyn.contact.EnableInConversationContext.EnableRule" />
      </EnableRules>
      <DisplayRules />
      <Actions>
        <JavaScriptFunction FunctionName="OmniChannelPackage.OmnichannelLinkCommand.linkRecordToConversation" Library="$webresource:msdyn_OmnichannelLinkCommand.js">
          <StringParameter Value="msdyn_contact_msdyn_ocliveworkitem_Customer" />
        </JavaScriptFunction>
      </Actions>
    </CommandDefinition>
  </CommandDefinitions>
  <RuleDefinitions>
    <TabDisplayRules />
    <DisplayRules />
    <EnableRules>
      <EnableRule Id="msdyn.contact.EnableInConversationContext.EnableRule">
        <CustomRule FunctionName="OmniChannelPackage.OmnichannelLinkCommand.shouldDisplayLinkCommand" Library="$webresource:msdyn_OmnichannelLinkCommand.js" Default="false" />
      </EnableRule>
    </EnableRules>
  </RuleDefinitions>
  <LocLabels>
    <LocLabel Id="msdyn.contact.LinkToConversation.Button.Alt">
      <Titles>
        <Title description="Link to conversation" languagecode="1033" />
      </Titles>
    </LocLabel>
    <LocLabel Id="msdyn.contact.LinkToConversation.Button.LabelText">
      <Titles>
        <Title description="Link to Conversation" languagecode="1033" />
      </Titles>
    </LocLabel>
    <LocLabel Id="msdyn.contact.LinkToConversation.Button.ToolTipDescription">
      <Titles>
        <Title description="Link to Conversation tooltip description" languagecode="1033" />
      </Titles>
    </LocLabel>
    <LocLabel Id="msdyn.contact.LinkToConversation.Button.ToolTipTitle">
      <Titles>
        <Title description="Link to conversation" languagecode="1033" />
      </Titles>
    </LocLabel>
  </LocLabels>
</RibbonDiffXml>
```

To learn more, see [Define ribbon actions](/powerapps/developer/model-driven-apps/define-ribbon-actions).


## Step 3: Enable display rules

Enable display rule for an entity, and add custom rule within the enable rule tag.

The `<CustomRule>` element calls a function in a JavaScript library that returns a Promise.

 Parameter name | Value | Comment |
|----------------------------|---------------------------------------|------------|
| `EnableRule Id` |   `msdyn.account.EnableInConversationContext.EnableRule` | |
| `Library` | `$webresource:msdyn_OmnichannelLinkCommand.js` | In the `<CustomRule>` element|
| `FunctionName` |`OmniChannelPackage.OmnichannelLinkCommand.shouldDisplayLinkCommand` | In the `<CustomRule>` element |

### Sample XML to enable display rules

```XML
<CommandDefinitions> 
    <CommandDefinition Id="msdyn.account.LinkToConversation.Command"> 
      <EnableRules> 
        <EnableRule Id="msdyn.account.EnableInConversationContext.EnableRule" /> 
      </EnableRules> 
      <DisplayRules /> 
      <Actions> 
        <JavaScriptFunction FunctionName="OmniChannelPackage.OmnichannelLinkCommand.linkRecordToConversation" Library="$webresource:msdyn_OmnichannelLinkCommand.js"> 
          <StringParameter Value="msdyn_account_msdyn_ocliveworkitem_Customer" /> 
        </JavaScriptFunction> 
      </Actions> 
    </CommandDefinition> 
  </CommandDefinitions> 
  <RuleDefinitions> 
    <TabDisplayRules /> 
    <DisplayRules /> 
    <EnableRules> 
      <EnableRule Id="msdyn.account.EnableInConversationContext.EnableRule"> 
        <CustomRule FunctionName="OmniChannelPackage.OmnichannelLinkCommand.shouldDisplayLinkCommand" Library="$webresource:msdyn_OmnichannelLinkCommand.js" Default="false" /> 
      </EnableRule> 
    </EnableRules> 
```

To learn more, see [Define ribbon display rules](/powerapps/developer/model-driven-apps/define-ribbon-display-rules)

## Step 4: Import the ribbon

In this step you need to import the customized ribbon.

To learn more, see [Import the ribbon](/powerapps/developer/model-driven-apps/export-prepare-edit-import-ribbon#import-the-ribbon).

## See also

[Export, prepare to edit, and import the ribbon](https://docs.microsoft.com/powerapps/developer/model-driven-apps/export-prepare-edit-import-ribbon#import-the-ribbon)

[Define ribbon enable rules](https://docs.microsoft.com/powerapps/developer/model-driven-apps/define-ribbon-enable-rules)

[Pass data from a page as a parameter to Ribbon Actions](https://docs.microsoft.com/powerapps/developer/model-driven-apps/pass-data-page-parameter-ribbon-actions)


[!INCLUDE[footer-include](../includes/footer-banner.md)]