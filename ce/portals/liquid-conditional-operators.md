---
title: "Use Liquid conditional operators for a portal in Dynamics 365 | MicrosoftDocs"
description: "Learn about the available liquid conditional operators in a portal."
ms.custom: dyn365-portal
ms.date: 09/28/2017
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 30c60ab3-85cb-470a-8b92-dd8a2c986caf
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Available Liquid conditional operators

When used in conditional statements (**if**,**unless**), some Liquid values will be treated as true, and some will be treated as false.

In Liquid, null and the Boolean value false are treated as false;everything else is treated as true. Empty strings, empty arrays, etc. are treated as true. For examples,

```
{% assign empty_string = "" %}
{% if empty_string %}
<p>This will render.</p>
{% endif %}
```
You can test for empty strings and arrays using the special value empty if necessary.

```
{% unless page.title == empty %}
<h1>{{ page.title }}</h1>
{% endunless %}
```
You can also test the size of [Liquid types](liquid-types.md), [Liquid types](liquid-types.md), or [Liquid types](liquid-types.md) using the special size property.

```
{% if page.children.size > 0 %}
<ul>
{% for child in page.children %}
<li>{{ child.title }}</li>
{% endfor %}
</ul>
{% endif %}
```

## Summary

|                           | True | False |
|---------------------------|------|-------|
| True                      | ×    |       |
| False                     |      | ×     |
| Null                      |      | ×     |
| String                    | ×    |       |
| empty string              | ×    |       |
| 0                         | ×    |       |
| 1, 3.14                   | ×    |       |
| array or dictionary       | ×    |       |
| empty array or dictionary | ×    |       |
| Object                    | ×    |       |

### See also

[Add dynamic content and create custom templates](custom-templates-dynamic-content.md)  
[Store source content by using web templates](store-content-web-templates.md)  
[Understand Liquid operators](liquid-operators.md)  
[Liquid types](liquid-types.md)  
[Liquid Objects](liquid-objects.md)  
[Liquid Tags](liquid-tags.md)  
[Liquid Filters](liquid-filters.md)  
[Create advanced templates for portals](create-advanced-templates.md)  
