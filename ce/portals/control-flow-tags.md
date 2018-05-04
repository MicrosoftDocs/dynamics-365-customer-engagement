---
title: "Use control flow tags for a portal in Dynamics 365 | MicrosoftDocs"
description: "Learn about control flow tags available in portal"
keywords: "control flow tags; liquid tags"
ms.date: 05/04/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: F9749B46-C4B5-4568-9B76-8E02112FB5F5
author: sbmjais
ms.author: shjais
manager: sakudes
ms.reviewer: 
topic-status: Drafting
---

# Control flow tags

Control Flow tags determine which block of code should be executed and what content should be rendered based on given conditions. Conditions are built using the available [Liquid operators](liquid-operators.md), or just based on [the truth or falsehood of a given value](#liquid-conditional-operators.md).  

## if

Executes a block of code if a given condition is met.

```
{% if user.fullname == 'Dave Bowman' %}

Hello, Dave.

{% endif %}
```

## unless

Like if, except it executes a block of code if a given condition is**not** met.

```
{% unless page.title == 'Home' %}

This is not the Home page.

{% endunless %}
```

## elsif/else

Adds more conditions to an if or unless block.

```
{% if user.fullname == 'Dave Bowman' %}

Hello, Dave.

{% elsif user.fullname == 'John Smith' %}

Hello, Mr. Smith.

{% else %}

Hello, stranger.

{% endif %}
```

## case/when

A switch statement to compare a variable to different values, and execute a different block of code for each value.

```
{% case user.fullname %}

{% when 'Dave Bowman' %}

Hello, Dave.

{% when 'John Smith' %}

Hello, Mr. Smith.

{% else %}

Hello, stranger.

{% endcase %}
```

### See also

[Iteration tags](iteration-tags.md)<br>
[Variable tags](variable-tags.md)<br>
[Template tags](template-tags.md)<br>
[Dynamics 365 entity tags](dynamics-entity-tags.md)
