---
title: "Render the entity list associated with the current page in a portal in Dynamics 365 | MicrosoftDocs"
description: "Sample code to render the entity list associated with the current page in a portal."
ms.custom: dyn365-portal
ms.date: 09/28/2017
ms.service: dynamics-365-customerservice
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

Render the Entity List associated with the current page as a paginated sortable table. Uses entitylist, entityview ([[!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] entity tags](#dynamics-365-entity-tags)), [page](#page), and [request](#request) parameters, and includes search and multiple view selection.  

```
{%entitylistid:page.adx_entitylist.id%}
<divclass="navbar navbar-default">
<divclass="container-fluid">
<divclass="navbar-header">
<buttontype="button"class="navbar-toggle"data-toggle="collapse"data-target="#entitylist-navbar-{{entitylist.id}}">
<spanclass="sr-only">
Toggle navigation
</span>
<spanclass="icon-bar">
</span>
<spanclass="icon-bar">
</span>
<spanclass="icon-bar">
</span>
</button>
<aclass="navbar-brand"href="{{page.url}}">
{{entitylist.adx_name}}
</a>
</div>
<divclass="collapse navbar-collapse"id="entitylist-navbar-{{entitylist.id}}">
{%ifentitylist.views.size>1%}
<ulclass="nav navbar-nav">
<liclass="dropdown">
<ahref="#"class="dropdown-toggle"data-toggle="dropdown">
<iclass="fa fa-list">
</i>
Views 
<spanclass="caret">
</span>
</a>
<ulclass="dropdown-menu"role="menu">
{%forviewinentitylist.views-%}
<li{%ifparams.view==view.id%}class="active"{%endif%}>
<ahref="{{request.path|add_query:'view',view.id}}">
{{view.name}}
</a>
</li>
{%endfor -%}
</ul>
</li>
</ul>
{%endif%}{%ifentitylist.search_enabled%}
<formclass="navbar-form-navbar-left" method="get">
<divclass="input-group">
{%ifparams.search.size>0%}
<divclass="input-group-btn">
<aclass="btn btn-default"href="{{request.path_and_query|remove_query:'search'}}">&times;
</a>
</div>
{%endif%}
<inputname="search"class="form-control"value="{{params.search}}"placeholder="{{entitylist.search_placeholder|default:'Search'}}"type="text"/>
<divclass="input-group-btn">
<buttontype="submit"class="btn-btn-default" title="{{entitylist.search_tooltip}}">
<iclass="fa fa-search">&nbsp;
</i>
</button>
</div>
</div>
</form>
{%endif%}{%ifentitylist.create_enabled%}
<ulclass="nav navbar-nav navbar-right">
<li>
<ahref="{{entitylist.create_url}}">
<iclass="fa-plus">
</i>
{{entitylist.create_label|default:'Create'}}
</a>
</li>
</ul>
{%endif%}
</div>
</div>
</div>{%entityviewid:params.view,search:params.search,order:params.order,page:params.page,pagesize:params.pagesize,metafilter:params.mf%}{%assignorder=params.order|default:entityview.sort_expression%}
<tableclass="table"data-order="{{order}}">
<thead>
<tr>
{%forcinentityview.columns-%}
<thwidth="{{c.width}}"data-logicalname="{{c.logical_name}}">
{%ifc.sort_enabled%}{%assigncurrent_sort=order|current_sort:c.logical_name%}{%casecurrent_sort%}{%when'ASC'%}
<ahref="{{request.path_and_query|add_query:'order',c.sort_descending}}">
{{c.name}}
<iclass="fa fa-sort-asc">
</i>
</a>
{%when'DESC'%}
<ahref="{{request.path_and_query|add_query:'order',c.sort_ascending}}">
{{c.name}}
<iclass="fa fa-sort-desc">
</i>
</a>
{%else%}
<ahref="{{request.path_and_query|add_query:'order',c.sort_ascending}}">
{{c.name}}<iclass="fa-unsorted">
</i>
</a>
{%endcase%}{%else%}{{c.name}}{%endif%}
</th>
{%endfor -%}
<thwidth="1">
</th>
</tr>
</thead>
<tbody>
{%foreinentityview.records -%}
<tr>
{%forcinentityview.columns -%}{%assignattr=e[c.logical_name]%}{%assignattr_type=c.attribute_type|downcase%}
<tddata-logicalname="{{c.logical_name}}">
{%ifattr.is_entity_reference-%}{{attr.name}}{%elsifattr_type=='datetime'%}{%ifattr%}
<timedatetime="{{attr|date_to_iso8601}}">
{{attr}}
</time>
{%endif%}{%elsifattr_type=='picklist'%}{{attr.label}}{%else%}{{attr}}{%endif -%}
</th>
{%endfor -%}
<td>
{%ifentitylist.detail_enabled-%}
<aclass="btn btn-default btn-xs"href="{{entitylist.detail_url}}?{{entitylist.detail_id_parameter}}={{e.id}}"title="{{entitylist.detail_label}}">
<iclass="fa fa-external-link">
</i>
</a>
{%endif -%}
</td>
<tr>
{%endfor -%}
</tbody>
</table>
{%ifentityview.pages.size>0%}{%assignfirst_page=entityview.first_page%}{%assignlast_page=entityview.last_page%}{%assignpage_offset=entityview.page|minus:1|divided_by:10|times:10%}{%assignpage_slice_first_page=page_offset|plus:1%}{%assignpage_slice_last_page=page_offset|plus:10%}
<ulclass="pagination">
<li{%unlessfirst_pageandentityview.page>1%}class="disabled"{%endunless%}><a{%iffirst_pageandentityview.page>1%}href="{{request.url|add_query:'page',first_page|path_and_query}}"{%endif%}>
&laquo;
</a>
</li>
<li{%unlessentityview.previous_page%}class="disabled"{%endunless%}>
<a{%ifentityview.previous_page%}href="{{request.url|add_query:'page',entityview.previous_page|path_and_query}}"{%endif%}>
&lsaquo;
</a>
</li>
{%ifpage_slice_first_page>1%}{%assignprevious_slice_last_page=page_slice_first_page|minus:1%}
<li>
<ahref="{{request.url|add_query:'page',previous_slice_last_page|path_and_query}}">
&hellip;
</a>
</li>
{%endif%}{%forpageinentityview.pagesoffset:page_offsetlimit:10-%}
<li{%ifpage==entityview.page%}class="active"{%endif%}>
<ahref="{{request.url|add_query:'page',page|path_and_query}}">
{{page}}
</a>
</li>
{%endfor -%}{%ifpage_slice_last_page<entityview.pages.size%}{%assignnext_slice_first_page=page_slice_last_page|plus:1%}
<li>
<ahref="{{request.url|add_query:'page',next_slice_first_page|path_and_query}}">
&hellip;
</a>
</li>
{%endif%}
<li{%unlessentityview.next_page%}class="disabled"{%endunless%}>
<a{%ifentityview.next_page%}href="{{request.url|add_query:'page',entityview.next_page|path_and_query}}"{%endif%}>
&rsaquo;
</a>
</li>
<li{%unlesslast_pageandentityview.page
<last_page%}class="disabled"{%endunless%}>
<a{%iflast_pageandentityview.page
<last_page%}href="{{request.url|add_query:'page',last_page|path_and_query}}"{%endif%}>
&raquo;
</a>
</li>
</ul>
{%endif%}{%endentityview%}{%endentitylist%}
```

### See also

[Create advanced templates for portals](create-advanced-templates.md)  
[Create a custom page template by using Liquid and a web template page template](create-custom-template.md)  
[Create a custom page template to render an RSS feed](render-rss-custom-page-template.md)  
[Render a website header and primary navigation bar](render-site-header-primary-navigation.md)  
[Render up to three levels of page hierarchy by using hybrid navigation](hybrid-navigation-render-page-hierachy.md)
