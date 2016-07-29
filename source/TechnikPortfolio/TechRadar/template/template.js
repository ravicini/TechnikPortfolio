document.title = "{{radar_title}";

var radar_arcs = [
    {'r':100,'name':'Adopt'},
    {'r':200,'name':'Trial'},
    {'r':300,'name':'Hold'},
    {'r':400, 'name':'DoNotTouch'}];

var h = 900;
var w = 1200;

var radar_data = [
    { "quadrant": "Frameworks",
        "left" : 45,
        "top" : 18,
        "color" : "#8FA227",
        "items" : {{top_left_data}}
    },
    { "quadrant": "Tools",
        "left": w-200+30,
        "top" : 18,
        "color" : "#587486",
        "items" : {{top_right_data}}
    },
    { "quadrant": "Platforms",
        "left" :45,
         "top" : (h/2 + 18),
        "color" : "#DC6F1D",
        "items" : {{bottom_left_data}}
    },
    { "quadrant": "Languages",
        "color" : "#B70062",
        "left"  : (w-200+30),
        "top" :   (h/2 + 18),
        "items" : {{bottom_right_data}}
    }
];