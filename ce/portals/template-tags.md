---
title: "Use template tags for a portal in Dynamics 365 | MicrosoftDocs"
description: "Learn about template tags available in portal"
keywords: "template tags; liquid tags"
ms.date: 05/04/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 78AED6A8-53CD-48C3-AE4B-0896E070406A
author: sbmjais
ms.author: shjais
manager: sakudes
ms.reviewer: 
topic-status: Drafting
---

# Template tags

Template tags control the output of a template in various ways, and allow the combination of multiple templates into a single output.

## include

Includes the contents of one template in another, by name. In [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] portals, the source of this other template will generally be a [web template](store-content-web-templates.md). This allows for the reuse of common template fragments in multiple places.  

When a template is included in another, the included template will have access to any variables defined in the parent template.

`{% include 'My Template' %}`

It's also possible to pass any number of named parameters to the include tag. These will then be defined as variables in the included template.

`{% include 'My Template' a:x, b:y %}`

## block

Used in conjunction with extends to provide template inheritance. See extends for usage.

## extends

Used in conjunction with the block tag, provides template inheritance. This allows multiple templates to use a shared layout, while overriding specific areas of the parent layout.

In [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] portals, the parent template name provided to the tag will generally refer to the name of a [web template](store-content-web-templates.md).  

When extends is used, it must be the first content in the template, and can only be followed by one or more block tags.

If a block defined in the parent template is not overridden, its contents in the parent template (if any) will be rendered.

## comment

Allows you to leave un-rendered code inside a Liquid template. Any content within the block will not be rendered, and any Liquid code within will not be executed.

**Code**

`Hello{% comment %}, {{ user.fullname }}{% endcomment %}. My name is Charles.`

**Output**

`Hello. My name is Charles.`

## raw

Allows output of Liquid code on a page without having it parsed and executed.

**Output**

`Hello, {{ user.fullname }}. My name is Charles.`

### See also

[Control flow tags](control-flow-tags.md)<br>
[Iteration tags](iteration-tags.md)<br>
[Variable tags](variable-tags.md)<br>
[Dynamics 365 entity tags](dynamics-entity-tags.md)
