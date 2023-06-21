---
title: Define the message editor interface
description: Learn how to define the message editor interface.
author: udaykirang
ms.author: udayg
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 06/23/2023
ms.custom: bap-template 
---

# Define the message editor interface (optional)

With the unlimited variety of custom channels you can create, you may need to provide different message template editors. You can define how a message template editor should look and what attributes it contains to match the needs of a specific channel.

If you don't configure a message template editor, Dynamics 365 Sales uses a generic user interface editor. SMS channels use the native SMS editor.

## Create a custom entity

First, [create a custom table](/power-apps/maker/data-platform/data-platform-create-entity) that includes all the [message parts defined in your channel](custom-sms-message-parts.md). Use the same names but prefix the publisher; for example, **cr65f_text** for the message part with `msdyn_name` attribute **text**. This entity doesn't store anything. It's only used as metadata to define your message contract.

The entity must also include the **placeholders** attribute that's used for personalization in Dynamics 365 Sales. The **placeholders** attribute should also have the publisher prefix. For example:

```XML
..
<attributes>
        ..
        <attribute PhysicalName="cr65f_name">..</attribute>
        <attribute PhysicalName="cr65f_placeholders">..</attribute>
        <attribute PhysicalName="cr65f_text">..</attribute>
        ..
</attributes>
..
```

## Create a form

Next, create a form for the custom entity that will be loaded in the Sales content editor. The form should contain the `cr65f_text` and `cr65f_placeholders` attributes. For example:

```XML
..
<formid>{69723cfe-3835-4126-ab9a-a82a5b88c21d}</formid>
<form>
      <tabs>
        <tab verticallayout="true" id="{921c575b-3e4a-495c-867d-b8f6e1c113e0}" IsUserDefined="1">
          <labels>
            <label description="General" languagecode="1033" />
          </labels>
          <columns>
            <column width="100%">
              <sections>
                <section showlabel="false" showbar="false" IsUserDefined="0" id="{661ec403-bf06-41a0-86de-f93a05c558f6}">
                  <labels>
                    <label description="General" languagecode="1033" />
                  </labels>
                  <rows>
                    <row>
                      <cell id="{95b0236e-63bd-c6ea-52dc-d7b9c4dca696}" showlabel="true" locklevel="0">
                        <labels>
                          <label description="Text" languagecode="1033" />
                        </labels>
                        <control id="cr65f_text" classid="{F9A8A302-114E-466A-B582-6771B2AE0D92}" datafieldname="cr65f_text" disabled="false" uniqueid="{05bb6ed1-e802-412c-9813-7eded53f3f73}" />
                      </cell>
                    </row>
                    <row>
                      <cell id="{dc3b7ed4-9a3d-14e1-ac32-b851ea4e11c3}" showlabel="true" locklevel="0" visible="false">
                        <labels>
                          <label description="Placeholders" languagecode="1033" />
                        </labels>
                        <control id="cr65f_placeholders" classid="{E0DECE4B-6FC8-4a8f-A065-082708572369}" datafieldname="cr65f_placeholders" disabled="false" uniqueid="{b02dc4a0-7711-0a2a-0ce4-d0c384a17712}" />
                      </cell>
                    </row>
                  </rows>
                </section>
              </sections>
            </column>
          </columns>
        </tab>
      </tabs>
  ..
</form>
.. 
```

The form ID of this entity is assigned to **msdyn_messageformid attribute** at the [channel definition step](custom-define-sms-definition.md).

You can use custom controls on the form or out-of-the-box controls like **MsdynmktControls.RichTextControl.RichTextControl** that support personalization.

## Next step

[Define custom APIs](custom-sms-custom-api.md)