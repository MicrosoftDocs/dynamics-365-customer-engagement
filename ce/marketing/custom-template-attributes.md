---
title: "Use custom attributes to enable designer features in templates (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to mark up the HTML in your email and page templates to enable drag-and-drop features and style controls for the Design view in Dynamics 365 for Marketing"
keywords: "custom attributes;templates;email;marketing pages;HTML"
ms.date: 08/01/2018
ms.service:
  - "crm-online"
ms.custom:
  - "dyn365-marketing"
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 346a437c-f9c7-47ea-94c6-c9deeadfa116
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Use custom attributes to enable designer features in emails, pages, and forms

The content designers provide both a graphical editor and an HTML code editor. The HTML that they generate is compatible with any HTML renderer, but they also support a few custom attributes that support the drag-and-drop content blocks and general style settings provided by the graphical editor. The default message templates and page templates provided with Dynamics 365 for Marketing make use of these custom attributes to make it easier for you to customize them in specific ways. You can also make use of these custom attributes when designing your own templates.

## Tag and attribute summary

The following table provides a quick reference to the custom attributes and meta tags described in this topic.

| Custom attribute | Description |
| --- | --- |
| `<meta type="xrm/designer/setting" name="type" value="marketing-designer-content-editor-document">` | When this tag is present in the `<head>` of your document, the **Designer** tab will provide drag-and-drop features. If this tag is not present, the **Designer** tab provides the simplified, full-page editor. More information: Show the toolbox and enable drag-and-drop editing |
| `<div data-container="true"> … </div>` | Marks the start and end of a container where users can drag and drop content blocks. More information Create a container where users can add content blocks |
| `<div data-editorblocktype="[text|image|button|...]" > … </div>` | Marks the start and end of a content block. The value of the attribute identifies which type of block it is (text, image, button, etc.). More information: Identify content blocks |
| `<meta type="xrm/designer/setting" name="<name>" value="<initial value>" datatype="[color|font|number|picture|text]" label="<label>">` | This tag defines a document-wide style setting that users can edit using the **Designer** > **Styles** tab.  More information: Add attributes to the Styles tab  |
| `/* @<tag-name> */ … /* @<tag-name> */` | Use CSS comments like these to surround a CSS value to be controlled by a style setting, where &lt;_tag-name&gt;_ is the value of the _name_ attribute for the meta tag that established the setting. More information: Add CSS comments to implement style settings in the head |
| `property-reference= "<attr>:@< tag-name >;<attr>:@< tag-name >; …"` | Place this attribute in any HTML tag to place an attribute with a value controlled by a style setting, where _&lt;attr&gt;_ is the name of the attribute to be created and &lt;_tag-name&gt;_ is the value of the _name_ attribute for the meta tag that established the setting. More information: Add property-reference attributes to implement style settings in the body |

The remaining sections of this topic provide more information about how to use each of the features summarized in the table.

<a name="show-toolbox"></a>

## Show the toolbox and enable drag-and-drop editing

You can paste HTML developed in any third-party tool directly into the **HTML** tab of the designer to start building a design very quickly. However, when you do this, the **Designer** tab will display as a single rich-text editor that provides a text-formatting toolbar, and shows all images, links, and styles included in your HTML, but doesn't otherwise provide the **Toolbox** , **Properties** , or **Styles** tabs, or any drag-and-drop functionality (this simplified **Designer** view is sometimes called the _full-page editor_.) However, you can enable drag-and-drop functionality for any pasted-in design by adding the following meta tag to the `<head>` section of your document:

```xml
<meta type="xrm/designer/setting" name="type" value="marketing-designer-content-editor-document">
```

The following image shows the same design in full-page-edit mode (left) and drag-and-drop mode (right). The only difference is the design on the right includes the meta tag, so drag-and-drop is enabled, and the side panel is shown.

![Full-page editor vs. drag-and-drop editor](media/designer-full-page-editor.png "Full-page editor vs. drag-and-drop editor")

> [!NOTE]
> When using the full-page editor, you can still select, edit and style text using the text-formatting toolbar (shown), and can also double-click on images, links, and other elements to set their properties using  a pop-up dialog. The toolbar also include the assist-edit button for adding dynamic content, such as field values drawn from each recipient's contact record.

<a name="containers"></a>

## Create a container where users can add content blocks

On the **Designer** tab, users can only edit content contained within a content block, and can only drag new content blocks into those parts of the document that are set up as _data containers_. Therefore, you can create templates where some elements are locked to editing on the **Design** tab, while others will accept edits and dragged content.

Use `<div>` tags that include the attribute `data-container="true"` to create data containers, such as:

```xml
<table aria-role="presentation">
    <tbody><tr>
        <td>
            LOCKED
        </td>
        <td>
            <div data-container="true">
                <!-- DRAG HERE -->
            </div>
        </td>
    </tr>
</tbody></table>
```

Any text or HTML tags that are nested within a **data-container** div-tag pair, and aren't part of a content block, will create a non-draggable, non-editable, area between two draggable areas. For example:

```xml
<div data-container="true">
    <!-- DRAG HERE --> <p> LOCKED </p> <!-- DRAG HERE -->
</div>
```
> [!NOTE]
> When the full-page editor is enabled, all drag-and-drop features are disabled, and you can edit all the content on the **Designer** tab, including content outside of `data-container` div tags (which have no effect in the full-page editor).

<a name="blocks"></a>

## Identify content blocks

Each time you add a content block using the **Designer** tab, the editor inserts a pair of `<div>` tags to mark the start and end of the block, and creates whatever HTML is required to display the block as specified in its settings on the **Properties** tab.

Content blocks are marked with `<div>` tags that include an attribute of the form `data-editorblocktype="[Text|Image|Button|Divider|…]`, where the value of this attribute identifies the type of block that it is. For example, the following `<div>` tag creates a text block:

```xml
<div data-editorblocktype="Text">
    ...
    <!-- Don't edit block content here -->
    ...
</div>
```

The following table lists the available values for the `data-editorblocktype` attribute.

| Content block name | Block type | `data-editorblocktype` attribute value |
| --- | --- | --- |
| Text block | Common&nbsp;design&nbsp;block | Text |
| Image block | Common design block | Image |
| Divider block | Common design block | Divider |
| Button block | Common design block | Button |
| Marketing-page block | Email | Marketing Page |
| Event block | Email | Event |
| Survey block | Email | Survey |
| Form block | Form | FormBlock |
| Field block | Form content | Field-_&lt;field-name&gt;_, for example: Field-email |
| Subscription-list block | Form content | SubscriptionListBlock |
| Forward-to-a-friend block | From content | ForwardToFriendBlock |
| Do-not- email block and Remember-me block | Form content | Field-checkbox (these blocks each create check boxes and are otherwise differentiated by their internal settings) |
| Submit-button block | Form content | SubmitButtonBlock |
| Rest-button block | Form content | ResetButtonBlock |
| Captcha block | Form content | CaptchaBlock |

For more information about each of these content blocks, see [Content blocks reference](content-blocks-reference.md).

> [!IMPORTANT]
> When you are working on the **HTML** tab, you should avoid editing any of the content between the `<div>` tags of your content blocks because the results of doing so can be unpredictable, and your edits are likely to be overwritten by the designer anyway. Instead, use the **Designer** tab to manage your content-block content and properties.

<a name="styles"></a>

## Add settings to the Styles tab

One handy feature of the out-of-box templates is that they provide global style settings on the **Styles** tab, which let users quickly adjust the font family, color palette, and other global settings enabled for the template. Each template includes only those styles settings that make sense for that specific design, and you can likewise design templates that provide just the right style settings for you and your users.

![The Designer > Styles tab](media/designer-style-tab.png "The Designer > Styles tab")

To add a setting to the **Styles** tab, you must do the following:

- Add a `<meta>` tag to the `<head>` of your document to create the setting.
- Set up styles and/or HTML tags that apply the settings created by the meta tag.

The following subsections explain how to do each of these things.

<a name="styles-meta"></a>

### Add a meta tag to create the setting

The required `<meta>` tag takes the following form:


```xml
<meta type="xrm/designer/setting" name="<name>" value="<initial-value>" datatype="<data-type>" label="<label>">
```

Where:

- _&lt;name&gt;_ identifies the meta tag, which you must also reference in the styles and HTML tags where the setting will be applied.
- _&lt;initial-value&gt;_ is an appropriate default value for the style.
- _&lt;data-type&gt;_ identifies the type of value users will provide. This setting affects the type of control that is presented on the **Styles** tab. You must use one of the values listed in the following table. 
- _&lt;label&gt;_ specifies the text to be shown in the **Styles** tab for the setting.

| Datatype&nbsp;value | Description |
| --- | --- |
| color | Sets a color using hash-tag values like #000 or #1a32bf. Creates a color-picker control on the **Styles** tab. |
| font | Sets a font-family name. You can also set up font stacks by using a comma-separated list of font names in order of preference. Creates a simple input field on the **Styles** tab. |
| number | Sets a numerical value with no unit (use text to allow units like _px_ or _em_ to be specified together with the value). Creates an input field with up/down buttons that can also be used to increment/decrement the current value on the **Styles** tab. |
| picture | Sets an image source (as a URL). Creates a simple input field on the **Styles** tab. |
| text | Sets a value that can include both text and numbers. Also use this data type for numerical values that may include a unit (like _px_ or _em_). Creates a simple input field on the **Styles** tab. |

> [!NOTE]
> The label shown on the **Styles** tab may appear in square brackets, such as "[My Style]". The square brackets indicate that the text being shown does not have a translation available. If you choose a value supported by any of the out-of-box templates (such as "Color 1"), then a translation will happen to be available, so the square brackets won't appear.

> [!NOTE]
> A style setting established using a `<meta>` tag, as described here, is only shown on the **Styles** tab when that setting is also referenced in at least one actual style or HTML tag, as described in the next sections.

<a name="styles-css"></a>

### Add CSS comments to implement style settings in the head

Settings made on the **Styles** tab can be applied to CSS styles established in the `<head>` of your HTML document by surrounding a CSS value with two CSS comments that contain the value of the `name` attribute for the matching `xrm/designer/setting` meta tag. The CSS comment pair takes the following form:

```css
/* @<tag-name> */ <value> /* @<tag-name> */
```

Where:

- _&lt;tag-name&gt;_ is the name attribute for the **xrm/designer/setting** meta tag that establishes the relevant **Styles** tab setting.
- _&lt;value&gt;_ is a value that will be replaced when a user edits the relevant **Styles** tab setting.

> [!IMPORTANT]
> You can only use these pairs of CSS comments in styles and classes defined within `<style>` tags in the `<head>` section. There must furthermore be only one set of `<style>` tags present, with all CSS styles set up there.

Here is an example where you can see an `xrm/designer/setting` meta tag that creates a color-picker control called "Color 1" on the **Styles** tab. A CSS style then applies this setting to establish the text color for `<h1>` elements.

```xml
<head>
    <meta type="xrm/designer/setting" name="color1" value="#ff0000" datatype="color" label="Color 1">
    <style>
        h1 {color: /* @color1 */ #ff0000 /* @color1 */;}
    </style>
</head>
```

<a name="styles-attribute"></a>

### Add property-reference attributes to implement style settings in the body

Settings made on the **Styles** tab can be applied as attribute values to any HTML tag in the `<body>` of your document by adding an attribute of the following form to each relevant tag:

```xml
property-reference= "<attr>:@< tag-name >;<attr>:@< tag-name >; …"
```

Where:

- _&lt;attr&gt;_ is the name of the attribute to be created
- _&lt;tag-name&gt;_ is the value of the `name` attribute for the meta tag that established the setting
- Multiple attributes, if needed, must be separated with a semicolon within a single property-reference attribute.

Here is an example where you can see `xrm/designer/setting` meta tags that create two settings for controlling a hero image (banner) in the document, with controls called "Hero image" and "Hero image height" on the **Styles** tab. The `property-reference` property is then used in an `<img>` tag to implement those settings.

```xml
<head>
    <meta type="xrm/designer/setting" name="hero-image" value="picture.jpg" datatype="picture" label="Hero image">
    <meta type="xrm/designer/setting" name="hero-image-height" value="100px" datatype="text" label="Hero image height">
</head>
<body>
    <img property-reference="src:@hero-image;height:@hero-image-height;">
</body>
```

So, in this example, the &lt;img&gt; tag would resolve to something like:

```xml
<img src="picture.jpg" height="100px">
```
