<div align="center">
  <img src="https://i.imgur.com/1hcm2K7.png" alt="ngx-docs">
    <h1>ngx-docs</h1>
    <h3><i>easy,responsive,fast,friendly</i></h3>
    <p>A ready to implement <b>angular 12</b> knowledge base template. </p>
 
</div>

## Features

- 2 Landing pages
- 3 detailed pages
- .net application for generating input & managing your project
- ngx-owl-carousel template page
- ngx-toastr, ngx-clipboard, angular-flexbox ,highlight-js
  

## Demo

The project's documentation is built using this template, play with it live here

## input.json accepted values

| Variable          | Type     |Optional?|Example|Note|
| ----------------- | -------- |--------|--------|----|
| id | Integer |**False**|"id":**1**|Auto-filled by the ngx-docs managment application
| Title |string |**False**|"Title":**"Entry title"**| The title displayed on every card
| Description |string| **True** | "Description":**"A little story"**|The description displayed under the card image
| text |string | **True** | "text":**"this is an entry about..."**|The main text of the entry
| image|string | **True**| "image":**"assets/images/default.png"**|The image displayed on the card
| code|string[]| **True**|  "code": **["int a=5;","public void main(){}"]**|The code blocks 
| items|string[]| **True**|  "items": **["a","b","c"]**|The items are displayed as list items
| tags |string[]| **True**| "tags":**["easy","searching"]**|The tags are mainly used in optimizing your searches
| url  |string| **True**| "url":**"google.com"**|If your entry has a relative url you can include it here
| album| string[]| **True**| "album":**["assets/images/1.png","assets/images/2.png"]**|If your entry has more than one iamge you can include them here

##### Sample json
```json
[
  {
    "id": 0,
    "Title": "What is Lorem Ipsum?",
    "Description": "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
    "text": "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,",
    "image": "assets/images/default.png",
    "items": [
      " It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
    ],
    "tags": [
      "lorem",
      "ipsum"
    ],
    "url": "https://www.lipsum.com/"
  },
  {
    "id": 1,
    "Title": "Where does it come from?",
    "Description": "\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"",
    "text": "\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\"",
    "image": "assets/images/default.png",
    "items": [
      "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat.\""
    ],
    "url": "https://www.lipsum.com/"
  },
  {
    "id": 2,
    "Title": "Where does it come from?",
    "Description": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce mauris mauris, mollis non eros nec, rutrum vulputate ligula. Nulla hendrerit dui vitae mollis scelerisque. Proin eleifend ligula eu scelerisque sagittis. Cras eu convallis nisl, at luctus est. Donec auctor velit quis diam mollis malesuada. Nulla mollis viverra eros, nec laoreet nisi vulputate quis. Maecenas pulvinar risus nec dui pellentesque sodales. Integer ac fringilla purus, ac malesuada ipsum. Donec bibendum vulputate mauris id eleifend. Vivamus est dui, pulvinar eget venenatis vitae, tincidunt non risus. Sed vel fringilla dolor, vitae accumsan sapien. ",
    "text": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce mauris mauris, mollis non eros nec, rutrum vulputate ligula. Nulla hendrerit dui vitae mollis scelerisque. Proin eleifend ligula eu scelerisque sagittis. Cras eu convallis nisl, at luctus est. Donec auctor velit quis diam mollis malesuada. Nulla mollis viverra eros, nec laoreet nisi vulputate quis. Maecenas pulvinar risus nec dui pellentesque sodales. Integer ac fringilla purus, ac malesuada ipsum. Donec bibendum vulputate mauris id eleifend. Vivamus est dui, pulvinar eget venenatis vitae, tincidunt non risus. Sed vel fringilla dolor, vitae accumsan sapien. Nam malesuada eros eget sapien bibendum, eget convallis tortor hendrerit. Mauris auctor risus a diam venenatis, ac blandit ex suscipit. Nulla interdum enim lectus, sollicitudin mattis magna vulputate quis.",
    "image": "assets/images/default.png",
    "items": [
      "Pellentesque quis molestie magna. Sed feugiat sem vehicula risus elementum cursus. Duis quis augue id lacus suscipit feugiat eget quis dolor. Nullam fermentum sagittis turpis, aliquet ullamcorper metus interdum vitae. Fusce ante ligula, tristique quis orci at, vestibulum consequat magna. Phasellus hendrerit ante convallis mi faucibus vestibulum. Praesent iaculis nibh arcu, et consectetur ipsum porttitor a. Duis ultricies ante a est viverra imperdiet. Nulla facilisi."
    ],
    "tags": [
      "fun",
      "easy"
    ],
    "url": "https://www.lipsum.com/"
  },
  {
    "id": 3,
    "Title": "Lorem",
    "Description": "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam a rhoncus lectus, et condimentum dolor. Etiam quis diam nisl. Aenean sodales vestibulum ex, et sagittis urna pretium eu. Nunc vitae hendrerit nibh. Donec volutpat, ante in sagittis convallis, massa libero auctor ",
    "text": "felis, non egestas ligula urna id massa. Nam rhoncus, risus ac suscipit aliquet, augue elit congue leo, eget commodo dui velit vitae lacus. Suspendisse ac elementum justo.",
    "image": "assets/images/default.png",
    "items": [
      "Sed suscipit turpis in luctus convallis. Praesent gravida dolor quis dolor imperdiet pharetra. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Vivamus maximus purus dignissim, faucibus libero et, ullamcorper quam. Suspendisse laoreet justo sit amet tortor auctor tincidunt. Integer et arcu aliquam, molestie justo sit amet, accumsan nunc. Suspendisse potenti. Curabitur pellentesque condimentum erat, in euismod mauris tristique sed. Sed tempus risus at tortor fringilla varius. Praesent lobortis dolor neque, ac aliquam erat malesuada sed. Praesent varius consectetur enim id laoreet. Nullam eu tincidunt odio, vitae consequat orci. Suspendisse porta mattis sapien in pulvinar."
    ],
    "tags": [
      "keys",
      "food"
    ],
    "url": "https://www.lipsum.com/",
    "album": [
      "assets/images/default.png",
      "assets/images/default.png"
    ]
  },
  {
    "id": 4,
    "Title": "Ipsum",
    "Description": "Phasellus finibus pulvinar venenatis. In sollicitudin vestibulum congue. Maecenas massa risus, fringilla non erat quis, tincidunt feugiat sem. Curabitur aliquam urna vitae nunc posuere porta. In non pharetra sapien. Etiam at efficitur nisi. Proin sagittis, nisl et dictum egestas, enim enim fermentum tortor, id scelerisque magna neque sit amet tellus. Fusce iaculis erat eget diam gravida, quis facilisis libero varius. Nullam enim quam, pulvinar eu vehicula rutrum, vulputate vel sem. Nunc eu dolor egestas, eleifend justo non, porta sem. Duis nibh libero, viverra a risus eget, dignissim rhoncus magna. Morbi malesuada ex eget diam congue, non fringilla metus ultricies. Curabitur lacus felis, aliquet non egestas ac, faucibus non ex. Donec mollis eu ante eu vehicula.",
    "text": "Phasellus finibus pulvinar venenatis. In sollicitudin vestibulum congue. Maecenas massa risus, fringilla non erat quis, tincidunt feugiat sem. Curabitur aliquam urna vitae nunc posuere porta. In non pharetra sapien. Etiam at efficitur nisi. Proin sagittis, nisl et dictum egestas, enim enim fermentum tortor, id scelerisque magna neque sit amet tellus. Fusce iaculis erat eget diam gravida, quis facilisis libero varius. Nullam enim quam, pulvinar eu vehicula rutrum, vulputate vel sem. Nunc eu dolor egestas, eleifend justo non, porta sem. Duis nibh libero, viverra a risus eget, dignissim rhoncus magna. Morbi malesuada ex eget diam congue, non fring",
    "image": "assets/images/default.png",
    "items": [
      "Fusce ultrices dolor id laoreet iaculis. Integer vitae tellus molestie, dictum diam vitae, iaculis ligula. Suspendisse vel vehicula felis, et viverra massa. Nam tempus suscipit ante in blandit. Donec viverra diam a felis tristique mollis. Maecenas dictum sit amet sapien cursus congue. Suspendisse eu tellus nec orci varius posuere. Vestibulum eu condimentum magna. Duis efficitur mauris quis consequat ornare. Pellentesque pharetra lectus non maximus accumsan. Suspendisse quam odio, mattis non mi ac, dapibus ultricies augue. Praesent sagittis ultricies felis, id sollicitudin turpis varius in. Morbi at scelerisque lectus. Donec finibus, quam a dignissim vehicula, ex nunc gravida massa, nec sollicitudin erat ipsum ornare magna. Phasellus luctus nisi sed augue consectetur, bibendum porta tortor pretium.\r\n\r\n"
    ],
    "url": "https://www.lipsum.com/"
  }
]
```


## Contributing

Contributions are always welcome!

See `contributing.md` for ways to get started.

Please adhere to this project's `code of conduct`.

