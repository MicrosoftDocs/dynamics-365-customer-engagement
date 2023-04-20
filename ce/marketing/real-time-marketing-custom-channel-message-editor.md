---
title: "Define your message editor interface (optional) (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to define your message editor interface for real-time marketing custom channels in Dynamics 365 Marketing."
ms.date: 12/12/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Define your message editor interface (optional)

## Applicable channels: Custom 

### Why you need it:

> [!IMPORTANT]
> If there is no need to create a customized UI for the custom channel message editing experience, this step can be skipped. 

With an unlimited variety of custom channels that can be created, the need to create different message template editors arises. You can define how the message template editor should look and what attributes it will contain, to match the specific needs of your channel.

If the message template isn't configured, Dynamics 365 Marketing supports and will display a generic user interface editor. 

> [!NOTE]
> Channels of SMS type use the native SMS editor. 

### How to define it:

**First**, you must create your [own custom entity](/dynamics365/customerengagement/on-premises/customize/create-entities) that will include all the message parts defined in your channel ([step 3](real-time-marketing-custom-channel-message-parts.md)) with the exact same names but including the publisher prefix. For example, **cr65f_text** for the message part with msdyn_name attribute equals to “text”.  **This entity will not store anything - it is only used as metadata to define your message contract**. On top of it, the entity must include the **placeholders** attribute that is used for personalization in Marketing. The **placeholders** attribute should also have the publisher prefix. For example:

```
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

**Second**, you must create a form for this custom entity that will be loaded at Marketing content editor. The form should contain the cr65f_text and cr65f_placeholders attributes. For example:

```
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

The form ID of this entity will be assigned to **msdyn_messageformid attribute** later at the [channel definition step](real-time-marketing-define-channel-definition.md).

You can use custom controls on the form or use the out-of-the-box Marketing controls such as the **MsdynmktControls.RichTextControl.RichTextControl** that support personalization.

[!INCLUDE[footer-include](../includes/footer-banner.md)]