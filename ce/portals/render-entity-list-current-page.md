---
title: "Render the entity list associated with the current page in a portal in Dynamics 365 | MicrosoftDocs"
description: ""
ms.custom: ""
ms.date: 05/22/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 51dd7c60-5c69-4dd5-9de5-6c4ee30b6526
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Render the entity list associated with the current page

Applies To: Dynamics 365 (online), Dynamics CRM Online

Render the Entity List associated with the current page, as a paginated, sortable table. Uses entitylist, entityview ([*Dynamics 365 entity tags*](#dynamics-365-entity-tags)), [*page*](#page), and [*request*](#request) parameters, and includes search and multiple view selection.  

**{%entitylistid:page.adx\_entitylist.id%}&lt;divclass="navbar navbar-default"&gt;&lt;divclass="container-fluid"&gt;&lt;divclass="navbar-header"&gt;&lt;buttontype="button"class="navbar-toggle"data-toggle="collapse"data-target="\#entitylist-navbar-{{entitylist.id}}"&gt;&lt;spanclass="sr-only"&gt;Toggle**

**navigation&lt;/span&gt;&lt;spanclass="icon-bar"&gt;&lt;/span&gt;&lt;spanclass="icon-bar"&gt;&lt;/span&gt;&lt;spanclass="icon-bar"&gt;&lt;/span&gt;&lt;/button&gt;&lt;aclass="navbar-brand"href="{{page.url}}"&gt;{{entitylist.adx\_name}}&lt;/a&gt;&lt;/div&gt;&lt;divclass="collapse**

**navbar-collapse"id="entitylist-navbar-{{entitylist.id}}"&gt;{%ifentitylist.views.size&gt;1%}&lt;ulclass="nav navbar-nav"&gt;&lt;liclass="dropdown"&gt;&lt;ahref="\#"class="dropdown-toggle"data-toggle="dropdown"&gt;&lt;iclass="fa fa-list"&gt;&lt;/i&gt; Views &lt;spanclass="caret"&gt;&lt;/span&gt;&lt;/a&gt;&lt;ulclass="dropdown-menu"role="menu"&gt;{%forviewinentitylist.views**

**-%}&lt;li{%ifparams.view==view.id%}class="active"{%endif%}&gt;&lt;ahref="{{request.path|add\_query:'view',view.id}}"&gt;{{view.name}}&lt;/a&gt;&lt;/li&gt;{%endfor -%}&lt;/ul&gt;&lt;/li&gt;&lt;/ul&gt;{%endif%}{%ifentitylist.search\_enabled%}&lt;formclass="navbar-form**

**navbar-left"method="get"&gt;&lt;divclass="input-group"&gt;{%ifparams.search.size&gt;0%}&lt;divclass="input-group-btn"&gt;&lt;aclass="btn btn-default"href="{{request.path\_and\_query|remove\_query:'search'}}"&gt;&times;&lt;/a&gt;&lt;/div&gt;{%endif%}&lt;inputname="search"class="form-control"value="{{params.search}}"placeholder="{{entitylist.search\_placeholder|default:'Search'}}"type="text"/&gt;&lt;divclass="input-group-btn"&gt;&lt;buttontype="submit"class="btn**

**btn-default"title="{{entitylist.search\_tooltip}}"&gt;&lt;iclass="fa fa-search"&gt;&nbsp;&lt;/i&gt;&lt;/button&gt;&lt;/div&gt;&lt;/div&gt;&lt;/form&gt;{%endif%}{%ifentitylist.create\_enabled%}&lt;ulclass="nav navbar-nav navbar-right"&gt;&lt;li&gt;&lt;ahref="{{entitylist.create\_url}}"&gt;&lt;iclass="fa**

**fa-plus"&gt;&lt;/i&gt;{{entitylist.create\_label|default:'Create'}}&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;{%endif%}&lt;/div&gt;&lt;/div&gt;&lt;/div&gt;{%entityviewid:params.view,search:params.search,order:params.order,page:params.page,pagesize:params.pagesize,metafilter:params.mf%}{%assignorder=params.order|default:entityview.sort\_expression%}&lt;tableclass="table"data-order="{{order}}"&gt;&lt;thead&gt;&lt;tr&gt;{%forcinentityview.columns**

**-%}&lt;thwidth="{{c.width}}"data-logicalname="{{c.logical\_name}}"&gt;{%ifc.sort\_enabled%}{%assigncurrent\_sort=order|current\_sort:c.logical\_name%}{%casecurrent\_sort%}{%when'ASC'%}&lt;ahref="{{request.path\_and\_query|add\_query:'order',c.sort\_descending}}"&gt;{{c.name}}&lt;iclass="fa**

**fa-sort-asc"&gt;&lt;/i&gt;&lt;/a&gt;{%when'DESC'%}&lt;ahref="{{request.path\_and\_query|add\_query:'order',c.sort\_ascending}}"&gt;{{c.name}}&lt;iclass="fa fa-sort-desc"&gt;&lt;/i&gt;&lt;/a&gt;{%else%}&lt;ahref="{{request.path\_and\_query|add\_query:'order',c.sort\_ascending}}"&gt;{{c.name}}&lt;iclass="fa**

**fa-unsorted"&gt;&lt;/i&gt;&lt;/a&gt;{%endcase%}{%else%}{{c.name}}{%endif%}&lt;/th&gt;{%endfor -%}&lt;thwidth="1"&gt;&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt;&lt;tbody&gt;{%foreinentityview.records -%}&lt;tr&gt;{%forcinentityview.columns -%}{%assignattr=e\[c.logical\_name\]%}{%assignattr\_type=c.attribute\_type|downcase%}&lt;tddata-logicalname="{{c.logical\_name}}"&gt;{%ifattr.is\_entity\_reference**

**-%}{{attr.name}}{%elsifattr\_type=='datetime'%}{%ifattr%}&lt;timedatetime="{{attr|date\_to\_iso8601}}"&gt;{{attr}}&lt;/time&gt;{%endif%}{%elsifattr\_type=='picklist'%}{{attr.label}}{%else%}{{attr}}{%endif -%}&lt;/th&gt;{%endfor -%}&lt;td&gt;{%ifentitylist.detail\_enabled**

**-%}&lt;aclass="btn btn-default btn-xs"href="{{entitylist.detail\_url}}?{{entitylist.detail\_id\_parameter}}={{e.id}}"title="{{entitylist.detail\_label}}"&gt;&lt;iclass="fa fa-external-link"&gt;&lt;/i&gt;&lt;/a&gt;{%endif -%}&lt;/td&gt;&lt;tr&gt;{%endfor -%}&lt;/tbody&gt;&lt;/table&gt;{%ifentityview.pages.size&gt;0%}{%assignfirst\_page=entityview.first\_page%}{%assignlast\_page=entityview.last\_page%}{%assignpage\_offset=entityview.page|minus:1|divided\_by:10|times:10%}{%assignpage\_slice\_first\_page=page\_offset|plus:1%}{%assignpage\_slice\_last\_page=page\_offset|plus:10%}&lt;ulclass="pagination"&gt;&lt;li{%unlessfirst\_pageandentityview.page&gt;1%}class="disabled"{%endunless%}&gt;&lt;a{%iffirst\_pageandentityview.page&gt;1%}href="{{request.url|add\_query:'page',first\_page|path\_and\_query}}"{%endif%}&gt;&laquo;&lt;/a&gt;&lt;/li&gt;&lt;li{%unlessentityview.previous\_page%}class="disabled"{%endunless%}&gt;&lt;a{%ifentityview.previous\_page%}href="{{request.url|add\_query:'page',entityview.previous\_page|path\_and\_query}}"{%endif%}&gt;&lsaquo;&lt;/a&gt;&lt;/li&gt;{%ifpage\_slice\_first\_page&gt;1%}{%assignprevious\_slice\_last\_page=page\_slice\_first\_page|minus:1%}&lt;li&gt;&lt;ahref="{{request.url|add\_query:'page',previous\_slice\_last\_page|path\_and\_query}}"&gt;&hellip;&lt;/a&gt;&lt;/li&gt;{%endif%}{%forpageinentityview.pagesoffset:page\_offsetlimit:10**

**-%}&lt;li{%ifpage==entityview.page%}class="active"{%endif%}&gt;&lt;ahref="{{request.url|add\_query:'page',page|path\_and\_query}}"&gt;{{page}}&lt;/a&gt;&lt;/li&gt;{%endfor -%}{%ifpage\_slice\_last\_page&lt;entityview.pages.size%}{%assignnext\_slice\_first\_page=page\_slice\_last\_page|plus:1%}&lt;li&gt;&lt;ahref="{{request.url|add\_query:'page',next\_slice\_first\_page|path\_and\_query}}"&gt;&hellip;&lt;/a&gt;&lt;/li&gt;{%endif%}&lt;li{%unlessentityview.next\_page%}class="disabled"{%endunless%}&gt;&lt;a{%ifentityview.next\_page%}href="{{request.url|add\_query:'page',entityview.next\_page|path\_and\_query}}"{%endif%}&gt;&rsaquo;&lt;/a&gt;&lt;/li&gt;&lt;li{%unlesslast\_pageandentityview.page&lt;last\_page%}class="disabled"{%endunless%}&gt;&lt;a{%iflast\_pageandentityview.page&lt;last\_page%}href="{{request.url|add\_query:'page',last\_page|path\_and\_query}}"{%endif%}&gt;&raquo;&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;{%endif%}{%endentityview%}{%endentitylist%}**

### See Also

[*Create advanced templates for portals*](create-advanced-templates.md)  
[*Create a custom page template by using Liquid and a web template page template*](create-custom-template.md)  
[*Create a custom page template to render an RSS feed*](render-rss-custom-page-template.md)  
[*Render a website header and primary navigation bar*](render-site-header-primary-navigation.md)  
[*Render up to three levels of page hierarchy by using hybrid navigation*](hybrid-navigation-render-page-hierachy.md)  

