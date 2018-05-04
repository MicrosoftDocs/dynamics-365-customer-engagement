---
title: "Use Liquid tags for a portal in Dynamics 365 | MicrosoftDocs"
description: "Learn about the available liquid tags in a portal."
ms.custom: dyn365-portal
ms.date: 09/28/2017
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 0a4b33a2-5f33-411e-a1de-33eb3f4cac84
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Available Liquid tags

Tags make up the programming logic that tells templates what to do. Tags are wrapped in {% %}.

```
{% if user.fullname == 'Dave Bowman' %} Hello, Dave. {% endif %}
```

## White space control

Normally, Liquid renders everything outside of variable and tag blocks verbatim, with all the white space as-is. Occasionally you don't want the extra white space, but you still want to format the template cleanly, which requires white space.

You can tell the engine to strip all leading or trailing white space by adding a hyphen (-) to the start or end block tag.

**Code**

```
{% for i in (1..5) --%}

{{ i }}

{%-- endfor %}
```

**Output**

```
12345
```
### See also

[Add dynamic content and create custom templates](custom-templates-dynamic-content.md)  
[Liquid types](liquid-types.md)  
[Liquid Objects](#liquid-objects)  
[Liquid Filters](liquid-filters.md) 
