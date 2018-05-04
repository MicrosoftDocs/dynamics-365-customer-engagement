---
title: "Use variable tags for a portal in Dynamics 365 | MicrosoftDocs"
description: "Learn about variable tags available in portal"
keywords: "variable tags; liquid tags"
ms.date: 05/04/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 59FD4F2D-8F26-4B9D-818F-E37C10156396
author: sbmjais
ms.author: shjais
manager: sakudes
ms.reviewer: 
topic-status: Drafting
---

# Variable tags

Variable tags are used to create new Liquid variables.

## assign

Creates a new variable. Assignments can also use [filters](liquid-filters.md) to modify the value.  

**Code**

```
{% assign is_valid = true %}

{% if is_valid %}

It is valid.

{% endif %}

{% assign name = "dave bowman' | upcase %}

{{ name }}
```

**Output**

```
It is valid.

DAVE BOWMAN
```

## capture

Captures the content within its block and assigns it to a variable. This content can then be rendered later by using output tags.

**Code**

```
{% capture hello %}Hello, {{ user.fullname }}.{% endcapture %}

{{ hello }}

{{ hello }}
```

**Output**

```
Hello, DAVE BOWMAN.

Hello, DAVE BOWMAN.
```

### See also

[Control flow tags](control-flow-tags.md)<br>
[Iteration tags](iteration-tags.md)<br>
[Template tags](template-tags.md)<br>
[Dynamics 365 entity tags](dynamics-entity-tags.md)