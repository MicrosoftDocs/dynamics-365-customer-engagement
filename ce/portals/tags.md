---
title: "Use tags for a portal in Dynamics 365 | MicrosoftDocs"
description: ""
ms.custom: ""
ms.date: 05/22/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 18dc6cfa-101c-4104-86b9-59a130fdcbfd
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Tags

The following topics describe each type of tag:

[*Control flow tags*](#control-flow-tags)  

[*Iteration tags*](#iteration-tags)  

[*Variable tags*](#variable-tags)  

[*Template tags*](#template-tags)  

[*Dynamics 365 entity tags*](#dynamics-365-entity-tags)  

### See Also

[*Add dynamic content and create custom templates*](custom-templates-dynamic-content.md)  
[*Store source content by using web templates*](store-content-web-templates.md)  
[*Understand Liquid operators*](liquid-operators.md)  
[*Liquid types*](liquid-types.md)  
[*Conditional*](liquid-conditional-operators.md)  
[*Liquid Objects*](liquid-objects.md)  
[*Liquid Filters*](liquid-filters.md)  
[*Create advanced templates for portals*](create-advanced-templates.md)  

## Control flow tags



Control Flow tags determine which block of code should be executed and what content should be rendered based on given conditions. Conditions are built using the available [*Understand Liquid operators*](liquid-operators.md), or just based on [*Conditional*](#conditional).  

### **if**

Executes a block of code if a given condition is met.

**{% if user.fullname == 'Dave Bowman' %}**

**Hello, Dave.**

**{% endif %}**

### **unless**

Like if, except it executes a block of code if a given condition is **not** met.

**{% unless page.title == 'Home' %}**

**This is not the Home page.**

**{% endunless %}**

### **elsif/else**

Adds more conditions to an if or unless block.

**{% if user.fullname == 'Dave Bowman' %}**

**Hello, Dave.**

**{% elsif user.fullname == 'John Smith' %}**

**Hello, Mr. Smith.**

**{% else %}**

**Hello, stranger.**

**{% endif %}**

### **case/when**

A switch statement to compare a variable to different values, and execute a different block of code for each value.

**{% case user.fullname %}**

**{% when 'Dave Bowman' %}**

**Hello, Dave.**

**{% when 'John Smith' %}**

**Hello, Mr. Smith.**

**{% else %}**

**Hello, stranger.**

**{% endcase %}**

### See Also

[*Add dynamic content and create custom templates*](custom-templates-dynamic-content.md)  
[*Liquid types*](liquid-types.md)  
[*Liquid Objects*](liquid-objects.md)  
[*Liquid Tags*](liquid-tags.md)  
[*Liquid Filters*](liquid-filters.md)  

## Iteration tags



Iteration tags are used to run/render a block of code repeatedly.

### **for**

Executes a block of code repeatedly. It is most commonly used to iterate over the items in an array or dictionary.

Within the for tag block, the [*forloop*](#forloop) is available.  

Code

**{% for child\_page in page.children %}**

**&lt;a href="{{ child\_page.url }}"&gt;{{ child\_page.title }}&lt;/a&gt;**

**{% endfor %}**

Output

**&lt;a href="/parent/child1/"&gt;Child 1&lt;/a&gt;**

**&lt;a href="/parent/child2/"&gt;Child 2&lt;/a&gt;**

**&lt;a href="/parent/child3/"&gt;Child 3&lt;/a&gt;**

### **Parameters**

These parameters of for can be used alone, or in combination.

**limit**

Exits the loop after a given number of items.

Code

**{% for child\_page in page.children limit:2 %}**

**&lt;a href="{{ child\_page.url }}"&gt;{{ child\_page.title }}&lt;/a&gt;**

**{% endfor %}**

Output

**&lt;a href="/parent/child1/"&gt;Child 1&lt;/a&gt;**

**&lt;a href="/parent/child2/"&gt;Child 2&lt;/a&gt;**

**offset**

Starts the loop at given index.

Code

**{% for child\_page in page.children offset:1 %}**

**&lt;a href="{{ child\_page.url }}"&gt;{{ child\_page.title }}&lt;/a&gt;**

**{% endfor %}**

Output

**&lt;a href="/parent/child2/"&gt;Child 2&lt;/a&gt;**

**&lt;a href="/parent/child3/"&gt;Child 3&lt;/a&gt;**

**range**

Defines a range of numbers to loop through.

Code

**{% assign n = 4 %}**

**{% for i in (2..n) %}**

**{{ i }}**

**{% endfor %}**

**{% for i in (10..14) %}**

**{{ i }}**

**{% endfor }}**

Output

**2 3 4**

**10 11 12 14**

**reversed**

Iterates through the loop in reverse order, starting from the last item.

Code

**{% for child\_page in page.children reversed %}**

**&lt;a href="{{ child\_page.url }}"&gt;{{ child\_page.title }}&lt;/a&gt;**

**{% endfor %}**

Output

**&lt;a href="/parent/child3/"&gt;Child 3&lt;/a&gt;**

**&lt;a href="/parent/child2/"&gt;Child 2&lt;/a&gt;**

**&lt;a href="/parent/child1/"&gt;Child 1&lt;/a&gt;**

### **cycle**

Loops through a group of strings and outputs them in the order that they were passed as parameters. Each time cycle is called, the next string that was passed as a parameter is output.

Code

**{% for item in items %}**

**&lt;div class="{% cycle 'red', 'green', 'blue' %}"&gt; {{ item }} &lt;/div&gt;**

**{% end %}**

Output

**&lt;div class="red"&gt; Item one &lt;/div&gt;**

**&lt;div class="green"&gt; Item two &lt;/div&gt;**

**&lt;div class="blue"&gt; Item three &lt;/div&gt;**

**&lt;div class="red"&gt; Item four &lt;/div&gt;**

**&lt;div class="green"&gt; Item five&lt;/div&gt;**

### **tablerow**

Generates an HTML table. Must be wrapped in an opening &lt;table&gt; and closing &lt;/table&gt; HTML tags.

Within the tablerow tag block, the [*tablerowloop*](#tablerowloop) is available.  

Code

**&lt;table&gt;**

**{% tablerow child\_page in page.children %}**

**{{ child\_page.title }}**

**{% endtablerow %}**

**&lt;/table&gt;**

Output

**&lt;table&gt;**

**&lt;tr class="row1"&gt;**

**&lt;td class="col1"&gt;**

**Child Page 1**

**&lt;/td&gt;**

**&lt;td class="col2"&gt;**

**Child Page 2**

**&lt;/td&gt;**

**&lt;td class="col3"&gt;**

**Child Page 3**

**&lt;/td&gt;**

**&lt;td class="col4"&gt;**

**Child Page 4**

**&lt;/td&gt;**

**&lt;/tr&gt;**

**&lt;/table&gt;**

### **Parameters**

These parameters of tablerowcan be used alone, or in combination.

Output

**&lt;table&gt;**

**&lt;tr class="row1"&gt;**

**&lt;td class="col1"&gt;**

**Child Page 1**

**&lt;/td&gt;**

**&lt;td class="col2"&gt;**

**Child Page 2**

**&lt;/td&gt;**

**&lt;/tr&gt;**

**&lt;tr class="row2"&gt;**

**&lt;td class="col3"&gt;**

**Child Page 3**

**&lt;/td&gt;**

**&lt;td class="col4"&gt;**

**Child Page 4**

**&lt;/td&gt;**

**&lt;/tr&gt;**

**&lt;/table&gt;**

Code

**&lt;table&gt;**

**{% tablerow child\_page in page.children cols:2 %}**

**{{ child\_page.title }}**

**{% endtablerow %}**

**&lt;/table&gt;**

Dictates how many rows the generated table should have.

**cols**

**limit**

Exits the loop after a given number of items.

Code

**&lt;table&gt;**

**{% tablerow child\_page in page.children limit:2 %}**

**{{ child\_page.title }}**

**{% endtablerow %}**

**&lt;/table&gt;**

Output

**&lt;table&gt;**

**&lt;tr class="row1"&gt;**

**&lt;td class="col1"&gt;**

**Child Page 1**

**&lt;/td&gt;**

**&lt;td class="col2"&gt;**

**Child Page 2**

**&lt;/td&gt;**

**&lt;/tr&gt;**

**&lt;/table&gt;**

**offset**

Starts the loop at given index.

Code

**&lt;table&gt;**

**{% tablerow child\_page in page.children offset:2 %}**

**{{ child\_page.title }}**

**{% endtablerow %}**

**&lt;/table&gt;**

Output

**&lt;table&gt;**

**&lt;tr class="row1"&gt;**

**&lt;td class="col1"&gt;**

**Child Page 3**

**&lt;/td&gt;**

**&lt;td class="col2"&gt;**

**Child Page 4**

**&lt;/td&gt;**

**&lt;/tr&gt;**

**&lt;/table&gt;**

**range**

Defines a range of numbers to loop through.

Code

**&lt;table&gt;**

**{% tablerow i in (1..3) %}**

**{{ i }}**

**{% endtablerow %}**

**&lt;/table&gt;**

### See Also

[*Add dynamic content and create custom templates*](custom-templates-dynamic-content.md)  
[*Liquid types*](liquid-types.md)  
[*Liquid Objects*](liquid-objects.md)  
[*Liquid Tags*](liquid-tags.md)  
[*Liquid Filters*](liquid-filters.md)  

## Variable tags



Variable tags are used to create new Liquid variables.

### **assign**

Creates a new variable. Assignments can also use [*Liquid Filters*](liquid-filters.md) to modify the value.  

Code

**{% assign is\_valid = true %}**

**{% if is\_valid %}**

**It is valid.**

**{% endif %}**

**{% assign name = "dave bowman' | upcase %}**

**{{ name }}**

Output

**It is valid.**

**DAVE BOWMAN**

### **capture**

Captures the content within its block and assigns it to a variable. This content can then be rendered later by using output tags.

Code

**{% capture hello %}Hello, {{ user.fullname }}.{% endcapture %}**

**{{ hello }}**

**{{ hello }}**

Output

**Hello, DAVE BOWMAN.**

**Hello, DAVE BOWMAN.**

### See Also

[*Add dynamic content and create custom templates*](custom-templates-dynamic-content.md)  
[*Liquid types*](liquid-types.md)  
[*Liquid Objects*](liquid-objects.md)  
[*Liquid Tags*](liquid-tags.md)  
[*Liquid Filters*](liquid-filters.md)  

## Template tags



Template tags control the output of a template in various ways, and allow the combination of multiple templates into a single output.

### **include**

Includes the contents of one template in another, by name. In Dynamics 365 portals, the source of this other template will generally be a [*web template*](store-content-web-templates.md). This allows for the reuse of common template fragments in multiple places.  

When a template is included in another, the included template will have access to any variables defined in the parent template.

**{% include 'My Template' %}**

It's also possible to pass any number of named parameters to the include tag. These will then be defined as variables in the included template.

**{% include 'My Template' a:x, b:y %}**

### **block**

Used in conjunction with extends to provide template inheritance. See extends for usage.

### **extends**

Used in conjunction with the block tag, provides template inheritance. This allows multiple templates to use a shared layout, while overriding specific areas of the parent layout.

In Dynamics 365 portals, the parent template name provided to the tag will generally refer to the name of a [*web template*](store-content-web-templates.md).  

When extends is used, it must be the first content in the template, and can only be followed by one or more block tags.

If a block defined in the parent template is not overridden, its contents in the parent template (if any) will be rendered.

### **comment**

Allows you to leave un-rendered code inside a Liquid template. Any content within the block will not be rendered, and any Liquid code within will not be executed.

Code

**Hello{% comment %}, {{ user.fullname }}{% endcomment %}. My name is Charles.**

Output

**Hello. My name is Charles.**

### **raw**

Allows output of Liquid code on a page without having it parsed and executed.

Output

**Hello, {{ user.fullname }}. My name is Charles.**

### See Also

[*Add dynamic content and create custom templates*](custom-templates-dynamic-content.md)  
[*Liquid types*](liquid-types.md)  
[*Liquid Objects*](liquid-objects.md)  
[*Liquid Tags*](liquid-tags.md)  
[*Liquid Filters*](liquid-filters.md)  

## Dynamics 365 entity tags



Dynamics 365 entity tags are used to load and display Dynamics 365 data, or use other Dynamics 365 portals framework services. These tags are Dynamics 365-specific extensions to the Liquid language.

### **editable**

Renders a given Dynamics 365 portals CMS object as [*Use the front-side editing engine to publish content*](publish-content-editing-engine.md), for users with content editing permission for that object. Editable objects include [*page*](#page), [*snippets*](#snippets), and [*weblinks*](#weblinks).  

**{% editable page 'adx\_copy' type: 'html', title: 'Page Copy', escape: false, liquid: true %}**

**{% editable snippets "Header" type: 'html' %}**

**&lt;!--**

**An editable web link set required a specific DOM structure, with**

**certain classes on the containing element, as demonstrated here.**

**--&gt;**

**{% assign primary\_nav = weblinks\["Primary Navigation"\] %}**

**{% if primary\_nav %}**

**&lt;div {% if primary\_nav.editable %}class="xrm-entity xrm-editable-adx\_weblinkset"{% endif %}&gt;**

**&lt;ul&gt;**

**&lt;!-- Render weblinks... --&gt;**

**&lt;/ul&gt;**

**{% editable primary\_nav %}**

**&lt;/div&gt;**

**{% endif %}**

### **Parameters**

The first parameter provided to editable is the editable object. For example, this may be a web link set, snippets, or the current page. The optional second parameter is to specify an attribute name or key within that object that is to be rendered and edited. This may be the name of an entity attribute, or a snippet name, for example.

After these initial parameters, the tag supports a number of optional named parameters.

**class**

Specifies a class attribute value for the root element rendered by this tag.

**default**

A default value to be rendered in the case that the editable item has no value.

**escape**

A Boolean value indicating whether a value rendered by this tag will be HTML-encoded. This is false by default.

**liquid**

A Boolean value indicating whether any Liquid template code found within the text value rendered by this tag will be processed. This is true by default.

**tag**

The name of the container HTML tags that will be rendered by this tag. This tag will render div elements by default. It is generally recommended that you choose between div or span as a value for this parameter.

**title**

Specifies a label for this editable item within the content editing interface. If none is provided, a friendly label will be generated automatically.

**type**

A string value indicating the type of editing interface to be presented, for editable text values. Valid values for this parameter are html or text. html is the default.

### **entitylist**

Loads a given entity list, by name or ID. The properties of the entity list can then be accessed using an [*entitylist*](#entitylist) that will be available within the tag block. To render the actual result records of the entity list, use the entityview tag within the block.  

If the entity list is loaded successfully, the content within the block will be rendered. If the entity list is not found, the block content will not be rendered.

**{% entitylist name:"My Entity List" %}**

**Loaded entity list {{ entitylist.adx\_name }}.**

**{% endentitylist %}**

By default, the entitylist object will be given the variable name entitylist. Optionally, a different variable name can be provided.

**{% entitylist my\_list = name:"My Entity List" %}**

**Loaded entity list {{ my\_list.adx\_name }}.**

**{% endentitylist %}**

|  >[!Note]                                                       |  
|-----------------------------------------------------------------------------------------------------------------------|
| [*Render the entity list associated with the current page*](render-entity-list-current-page.md) |  

### **Parameters**

Provide **only one** of id, name, or key to select the Entity List to load.

**id**

Loads an entity list by [*GUID*](http://en.wikipedia.org/wiki/Globally_unique_identifier) ID. id must be a string that can be parsed as a *GUID*.  

**{% entitylist id:"936DA01F-9ABD-4d9d-80C7-02AF85C822A8" %}**

**Loaded entity list {{ entitylist.adx\_name }}.**

**{% endentitylist %}**

Generally, literal GUID strings will not be used. Instead, id will be specified using a GUID property of another variable.

**{% entitylist id:page.adx\_entitylist.id %}**

**Loaded entity list {{ entitylist.adx\_name }}.**

**{% endentitylist %}**

**name**

Loads an entity list by name.

**{% entitylist name:"My Entity List" %}**

**Loaded entity list {{ entitylist.adx\_name }}.**

**{% endentitylist %}**

**key**

Loads an entity list by ID **or** name. If the provided key value can be parsed as a [*GUID*](http://en.wikipedia.org/wiki/Globally_unique_identifier), the entity list will be loaded by ID. Otherwise, it will be loaded by name.  

**&lt;!-- key\_variable can hold an ID or name --&gt;**

**{% entitylist key:key\_variable %}**

**Loaded entity list {{ entitylist.adx\_name }}.**

**{% endentitylist %}**

**language\_code**

A Dynamics 365 integer language code to select the entity list localized labels to be loaded. If no language\_code is provided, the default language of the portal application Dynamics 365 connection will be used.

**{% entitylist name:"My Entity List", language\_code:1033 %}**

**Loaded entity list {{ entitylist.adx\_name }}.**

**{% endentitylist %}**

### **entityview**

Loads a given Dynamics 365 view, by name or ID. The properties of the view ߝ view column metadata, paginated result records, etc. can then be accessed using an [*entityview*](#entityview) that will be available within the tag block.  

If the view is loaded successfully, the content within the block will be rendered. If the view is not found, the block content will not be rendered.

**{% entityview logical\_name:'contact', name:"Active Contacts" %}**

**Loaded entity view with {{ entityview.total\_records }} total records.**

**{% endentityview %}**

By default, the entityview object will be given the variable name entityview. Optionally, a different variable name can be provided.

**{% entityview my\_view = logical\_name:'contact', name:"Active Contacts" %}**

**Loaded entity view with {{ my\_view.total\_records }} total records.**

**{% endentityview %}**

If entityview is nested within an entitylist block, it will inherit its default configuration (result page size, filter options, etc.) from the entity list. If no view id or name parameters are provided to entityview, it will load the default view from the enclosing entitylist.

**{% entitylist id:page.adx\_entitylist.id %}**

**{% entityview %}**

**Loaded default view of the entity list associated with the current page, with {{ entityview.total\_records }} total records.**

**{% endentityview %}**

**{% endentitylist %}**

|  >[!Note]                                                       |  
|-----------------------------------------------------------------------------------------------------------------------|
| [*Render the entity list associated with the current page*](render-entity-list-current-page.md) |  

### **Parameters**

Provide **either** id **or** logical\_name with name to select the Dynamics 365 view to load. If neither is provided, and the entityview tag is nested within an entitylist tag, the default view of the enclosing entitylist will be loaded.

**id**

id must be a string that can be parsed as a GUID.

**{% entityview id:"936DA01F-9ABD-4d9d-80C7-02AF85C822A8" %}**

**Loaded entity view {{ entityview.name }}.**

**{% endentityview %}**

Generally, literal GUID strings will not be used. Instead, id will be specified using a GUID property of another variable.

**{% entityview id:request.params.view %}**

**Loaded entity view {{ entityview.name }} using "view" query string request parameter.**

**{% endentityview %}**

**logical\_name**

The Dynamics 365 entity logical name of the view to be loaded. Must be used in combination with name.

**{% entityview logical\_name:'contact', name:"Active Contacts" %}**

**Loaded entity view with {{ entityview.total\_records }} total records.**

**{% endentityview %}**

**name**

The Dynamics 365 name of the view to be loaded. Must be used in combination with logical\_name.

**{% entityview logical\_name:'contact', name:"Active Contacts" %}**

**Loaded entity view with {{ entityview.total\_records }} total records.**

**{% endentityview %}**

**filter**

Specifies whether to filter the view results by user or account. Must have a string value of "user" or "account".

**{% entityview id:request.params.view, filter:'user' %}**

**Loaded entity view with {{ entityview.total\_records }} total records.**

**{% endentityview %}**

A common use case is to set this parameter based on a [*request*](#request).  

**{% entityview id:request.params.view, filter:request.params.filter %}**

**Loaded entity view with {{ entityview.total\_records }} total records.**

**{% endentityview %}**

**metafilter**

Specifies the Entity List metadata filter expression by which to filter view results. This parameter is only valid when entityview is used in combination with entitylist. In most cases, this parameter is set based on a [*request*](#request).  

**{% entitylist id:page.adx\_entitylist.id %}**

**{% entityview id:request.params.view, metafilter:request.params.mf %}**

**Loaded entity view with {{ entityview.total\_records }} total records.**

**{% endentityview %}**

**{% endentitylist %}**

|  >[!Note] |  
|-----------------------------------------------------------------|
| [*Entity List filters*](#entity-list-filters)                   |  

**order**

Specifies a sort expression for ordering view results. A sort expression can contain one or more entity attribute logical names, followed by a sort direction of either ASC or DESC.

**{% entityview id:request.params.view, order:'name ASC, createdon DESC' %}**

**Loaded entity view with {{ entityview.total\_records }} total records.**

**{% endentityview %}**

A common use case is to set this parameter based on a [*request*](#request).  

**{% entityview id:request.params.view, order:request.params.order %}**

**Loaded entity view with {{ entityview.total\_records }} total records.**

**{% endentityview %}**

**page**

Specifies the view result page to load. If this parameter is not specified, the first page of results will be loaded.

This parameter must be passed either an integer value, or a string that can be parsed as an integer. If a value is provided for this parameter, but the value is null or otherwise cannot be parsed as an integer, the first page of results will be loaded.

**{% entityview id:request.params.view, page:2 %}**

**Loaded page {{ entityview.page }} of entity view with {{ entityview.total\_records }} total records.**

**{% endentityview %}**

A common use case is to set this parameter based on a [*request*](#request).  

**{% entityview id:request.params.view, page:request.params.page %}**

**Loaded page {{ entityview.page }} of entity view with {{ entityview.total\_records }} total records.**

**{% endentityview %}**

**page\_size**

Specifies the number of results to load for the current result page. If no value is provided for this parameter, and entityview is used within an entitylist block, the entity list page size will be used. If not within an entitylist block, a default value of 10 will be used.

This parameter must be passed either an integer value, or a string that can be parsed as an integer. If a value is provided for this parameter, but the value is null or otherwise cannot be parsed as an integer, the default page size will be used.

**{% entityview id:request.params.view, page\_size:20 %}**

**Loaded entity view with {{ entityview.total\_records }} total records.**

**{% endentityview %}**

A common use case is to set this parameter based on a [*request*](#request).  

**{% entityview id:request.params.view, page\_size:request.params.pagesize %}**

**Loaded entity view with {{ entityview.total\_records }} total records.**

**{% endentityview %}**

**search**

Specifies a search expression by which to filter view results. Simple keyword search expressions will filter by whether attributes begin with the keyword. Wildcards \* can also be included in the expression.

**{% entityview id:request.params.view, search:'John\*' %}**

**Loaded entity view with {{ entityview.total\_records }} total matching records.**

**{% endentityview %}**

A common use case is to set this parameter based on a [*request*](#request), so that the search filter can be set based on user input.  

**{% entityview id:request.params.view, search:request.params.search %}**

**Loaded entity view with {{ entityview.total\_records }} total matching records.**

**{% endentityview %}**

**enable\_entity\_permissions**

Specifies whether to apply entity permission filtering on view results. This parameter is set to false by default. If entityview is used within an entitylist block, the value of this parameter will be inherited from the entity list configuration.

This parameter must be passed either an [*Liquid types*](liquid-types.md) value, or a string that can be parsed as a Boolean ("true", "false"). If a value is provided for this parameter, but the value is null or otherwise cannot be parsed as a Boolean, the default of false will be used.  

**{% entityview id:request.params.view, enable\_entity\_permissions:true %}**

**Loaded entity view with {{ entityview.total\_records }} total records to which the user has read permission.**

**{% endentityview %}**

**language\_code**

A Dynamics 365 integer language code to select the entity view localized labels (column header labels, etc.) to be loaded. If no language\_code is provided, the default language of the portal application Dynamics 365 connection will be used.

If entityview is used within an entitylist block, entityview will inherit its language code configuration from entitylist.

**{% entityview logical\_name:'contact', name:"Active Contacts", language\_code:1033 %}**

**Loaded entity view {{ entityview.name }}.**

**{% endentitylist %}**

### **searchindex **

Performs a query against the portal search index. The matching results can then be accessed using a [*searchindex*](#searchindex) that will be available within the tag block.  

**{% searchindex query: 'support', page: params.page, page\_size: 10 %}**

**{% if searchindex.results.size &gt; 0 %}**

**&lt;p&gt;Found about {{ searchindex.approximate\_total\_hits }} matches:&lt;/p&gt;**

**&lt;ul&gt;**

**{% for result in searchindex.results %}**

**&lt;li&gt;**

**&lt;h3&gt;&lt;a href="{{ result.url | escape }}"&gt;{{ result.title | escape }}&lt;/a&gt;&lt;/h3&gt;**

**&lt;p&gt;{{ result.fragment }}&lt;/p&gt;**

**&lt;/li&gt;**

**{% endfor %}**

**&lt;/ul&gt;**

**{% else %}**

**&lt;p&gt;Your query returned no results.&lt;/p&gt;**

**{% endif %}**

**{% endsearchindex %}**

By default, the search index object will be given the variable name searchindex. Optionally, a different variable name can be provided.

**{% searchindex liquid\_search = query: 'support', page: params.page, page\_size: 10 %}**

**{% if liquid\_search.results.size &gt; 0 %}**

**...**

**{% endif %}**

**{% endsearchindex %}**

### **Parameters**

The searchindex tag accepts the following parameters.

**query**

The query used to match results. This parameter is intended to accept the user-specified part of the index query (if any).

**{% searchindex query: 'support' %}**

**...**

**{% endsearchindex %}**

A common use case is to set this parameter based on a [*request*](#request).  

**{% searchindex query: request.params.query %}**

**...**

**{% endsearchindex %}**

This parameter supports [*the Lucene Query Parser syntax*](http://lucene.apache.org/core/2_9_4/queryparsersyntax.html).  

**filter**

An additional query used to match results. This parameter is intended to accept a developer-specified filter for results, if desired.

**{% searchindex query: request.params.query, filter: '+statecode:0' %}**

**...**

**{% endsearchindex %}**

This parameter supports [*the Lucene Query Parser syntax*](http://lucene.apache.org/core/2_9_4/queryparsersyntax.html).  

|  >[!Note]                                                                                                                                                                                        |  
|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| The difference between filter and query is that while both will accept the Lucene Query Parser syntax, query is intended to be more forgiving about how this syntax is parsed ߝ as it's expected that most end users will not be aware of this syntax. 
                                                                                                                                                                                                                                                         
 So, in the case that parsing query according to this syntax fails, the entire query will be escaped and submitted as the query text. filter, on the other hand, will be parsed strictly and return an error if the case of invalid syntax.              |

**logical\_names**

The Dynamics 365 entity logical names to which matching results will be restricted, as a comma-delimited string. If not provided, all matching entities will be returned.

**{% searchindex query: request.params.query, logical\_names: 'kbarticle,incident' %}**

**...**

**{% endsearchindex %}**

**page**

The search result page to be returned. If not provided, the first page (1) will be returned.

**{% searchindex query: request.params.query, page: 2 %}**

**...**

**{% endsearchindex %}**

A common use case is to set this parameter based on a [*request*](#request).  

**{% searchindex query: request.params.query, page: request.params.page %}**

**...**

**{% endsearchindex %}**

**page\_size**

The size of the result page to be returned. If not provided, a default size of 10 will be used.

**{% searchindex query: request.params.query, page\_size: 20 %}**

**...**

**{% endsearchindex %}**

**provider**

Specifies the name of the configured search provider to use. If not specified, the default search provider will be used.

Having multiple search providers is an advanced configuration that will not apply to most environments. Generally, it will not be necessary to specify this parameter.

**{% searchindex query: request.params.query, provider: 'AlternateIndex' %}**

**...**

**{% endsearchindex %}**

### **entityform **

Fully renders a Dynamics 365-configured [*Define entity forms and custom logic within the Dynamics 365 portal*](entity-forms-custom-logic.md), by name or ID.  

|  >[!Note]                                                                                                                                                                                        |  
|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| The entityform tag is only available for use in content rendered inside a *[web template](store-content-web-templates.md)–*based page template. Attempting to use the tag inside a Rewrite-based Page Template will not render anything.   
                                                                                                                                                                                                                                                         
 You may only render a single entityform or webform tag per page. entityform or webform tags after the first will not be rendered.                                                                                                                       |

**{% entityform name: 'My Entity Form' %}**

### **Parameters**

### **name**

The name of the Entity Form you wish to load.

**{% entityform name:"My Entity Form" %}**

**{% webform name:"My Web Form" %}**

The name of the Web Form you wish to load.

### **name**

### **Parameters**

### **webform **

Fully renders a Dynamics 365-configured web form, by name or ID.

|  >[!Note]                                                                                                                                                                                     |  
|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| The webform tag is only available for use in content rendered inside a *[web template](store-content-web-templates.md)–*based page template. Attempting to use the tag inside a Rewrite-based Page Template will not render anything.   
                                                                                                                                                                                                                                                      
 You may only render a single entityform or webform tag per page. entityform or webform tags after the first will not be rendered.                                                                                                                    |

**{% webform name: 'My Web Form' %}**

### See Also

[*Add dynamic content and create custom templates*](custom-templates-dynamic-content.md)  
[*Liquid types*](liquid-types.md)  
[*Liquid Objects*](liquid-objects.md)  
[*Liquid Tags*](liquid-tags.md)  
[*Liquid Filters*](liquid-filters.md)  

