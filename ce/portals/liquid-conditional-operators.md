# Conditional

Applies To: Dynamics 365 (online), Dynamics CRM Online

When used in conditional statements (**if**, **unless**), some Liquid values will be treated as true, and some will be treated as false.

In Liquid, null and the Boolean value false are treated as false; everything else is treated as true. Empty strings, empty arrays, etc. are treated as true.

**Examples:**

**{% assign empty\_string = "" %}**

**{% if empty\_string %}**

**&lt;p&gt;This will render.&lt;/p&gt;**

**{% endif %}**

You can test for empty strings and arrays using the special value empty if necessary.

**{% unless page.title == empty %}**

**&lt;h1&gt;{{ page.title }}&lt;/h1&gt;**

**{% endunless %}**

You can also test the size of [*Liquid types*](liquid-types.md), [*Liquid types*](liquid-types.md), or [*Liquid types*](liquid-types.md) using the special size property.  

**{% if page.children.size &gt; 0 %}**

**&lt;ul&gt;**

**{% for child in page.children %}**

**&lt;li&gt;{{ child.title }}&lt;/li&gt;**

**{% endfor %}**

**&lt;/ul&gt;**

**{% endif %}**

### **Summary**

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

### See Also

[*Add dynamic content and create custom templates*](custom-templates-dynamic-content.md)  
[*Store source content by using web templates*](store-content-web-templates.md)  
[*Understand Liquid operators*](liquid-operators.md)  
[*Liquid types*](liquid-types.md)  
[*Liquid Objects*](liquid-objects.md)  
[*Liquid Tags*](liquid-tags.md)  
[*Liquid Filters*](liquid-filters.md)  
[*Create advanced templates for portals*](create-advanced-templates.md)  

