<p align="center">
    # ngx-docs
</p>
A ready to implement boilerplate **angular 12** knowledge base search tool. 


## Demo

The project's documentation is built using this template, play with it live here

## input.json accepted values

| Variable          | Type     |Optional?|Example|Note|
| ----------------- | -------- |--------|--------|----|
| id | Integer |**False**|"id":**1**|Auto-filled by the ngx-docs managment application
| Title |string |**False**|"Title":**"Entry title"**| The title displayed on every card
| Description |string| **False** | "Description":**"A little story"**|The description displayed under the card image
| text |string | **False** | "text":**"this is an entry about..."**|The main text of the entry
| image|string | **False**| "image":**"assets/images/default.png"**|The image displayed on the card
| items|string[]| **False**|  "items": **["a","b","c"]**|The items are displayed as list items
| tags |string[]| **True**| "tags":**["easy","searching"]**|The tags are mainly used in optimizing your searches
| url  |string| **True**| "url":**"google.com"**|If your entry has a relative url you can include it here
| album| string[]| **True**| "album":**["assets/images/1.png","assets/images/2.png"]**|If your entry has more than one iamge you can include them here