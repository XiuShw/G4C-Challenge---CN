public class BlockType {
    public string name;

    public string displayName;

    public string foodGroup;

    public int size;

    public bool[][] shape;

    public BlockType(string _name, string _foodGroup, bool[][] _shape) {
        name = _name;
        displayName = _name;
        foodGroup = _foodGroup;

        shape = _shape;

        size = 0;
        
        for (int i = 0; i < shape.Length; ++i) {
            for (int j = 0; j < shape[i].Length; ++j) {
                if (shape[i][j]) {
                    ++size;
                }
            }
        }
    }

    public BlockType(string _name, string display, string _foodGroup, bool[][] _shape) {
        name = _name;
        displayName = display;
        foodGroup = _foodGroup;

        shape = _shape;

        size = 0;
        
        for (int i = 0; i < shape.Length; ++i) {
            for (int j = 0; j < shape[i].Length; ++j) {
                if (shape[i][j]) {
                    ++size;
                }
            }
        }
    }

    // FRUITS VEGETABLES

    public static BlockType apple() {
        return new BlockType("apple", "Æ»¹û", "veg", new bool[][] {
            new bool[] {true, true},
            new bool[] {true, true}
        });
    }

    public static BlockType mushroom() {
        return new BlockType("mushroom", "Ä¢¹½", "veg", new bool[][] {
            new bool[] {true, true, true},
            new bool[] {false, true, false}
        });
    }

    public static BlockType banana() {
        return new BlockType("banana", "Ïã½¶", "veg", new bool[][] {
            new bool[] {true, false, false},
            new bool[] {true, true, true}
        });
    }

    public static BlockType lettuce() {
        return new BlockType("lettuce", "Éú²Ë", "veg", new bool[][] {
            new bool[] {false, false, true},
            new bool[] {false, true, true},
            new bool[] {true, true, true}
        });
    }

    public static BlockType tomato() {
        return new BlockType("tomato", "·¬ÇÑ", "veg", new bool[][] {
            new bool[] {false, true, false},
            new bool[] {true, true, false},
            new bool[] {true, true, true}
        });
    }

    public static BlockType cucumber() {
        return new BlockType("cucumber", "»Æ¹Ï", "veg", new bool[][] {
            new bool[] {true, true, true}
        });
    }

    public static BlockType cabbage() {
        return new BlockType("cabbage", "¾íÐÄ²Ë", "veg", new bool[][] {
            new bool[] {true, true, true},
            new bool[] {true, true, true}
        });
    }

    public static BlockType broccoli() {
        return new BlockType("broccoli", "Î÷À¼»¨", "veg", new bool[][] {
            new bool[] {true, true, true},
            new bool[] {false, true, false},
            new bool[] {false, true, false}
        });
    }

    public static BlockType eggplant() {
        return new BlockType("eggplant", "ÇÑ×Ó", "veg", new bool[][] {
            new bool[] {true, false},
            new bool[] {true, true}
        });
    }

    public static BlockType carrot() {
        return new BlockType("carrot", "ºúÂÜ²·", "veg", new bool[][] {
            new bool[] {true},
            new bool[] {true}
        });
    }

    // CARB

    public static BlockType noodle() {
        return new BlockType("noodle", "ÃæÌõ", "carb", new bool[][] {
            new bool[] {true, true, true},
            new bool[] {true, true, true}
        });
    }

    public static BlockType rice() {
        return new BlockType("rice", "´óÃ×", "carb", new bool[][] {
            new bool[] {true, false, true},
            new bool[] {true, true, true}
        });
    }

    public static BlockType corn() {
        return new BlockType("corn", "ÓñÃ×", "carb", new bool[][] {
            new bool[] {true, true, true},
        });
    }

    public static BlockType bread() {
        return new BlockType("bread", "Ãæ°ü", "carb", new bool[][] {
            new bool[] {true, false, false},
            new bool[] {true, true, true}
        });
    }

    public static BlockType bread2() {
        return new BlockType("bread2", "Ãæ°ü", "carb", new bool[][] {
            new bool[] {true, true, false, false},
            new bool[] {false, true, true, true}
        });
    }

    public static BlockType bread3() {
        return new BlockType("bread3", "Ãæ°ü", "carb", new bool[][] {
            new bool[] {true, true, false},
            new bool[] {true, true, true}
        });
    }

    public static BlockType bread4() {
        return new BlockType("bread4", "·¨¹÷Ãæ°ü", "carb", new bool[][] {
            new bool[] {true, true, true, true}
        });
    }

    public static BlockType oats() {
        return new BlockType("oats", "ÑàÂó", "carb", new bool[][] {
            new bool[] {true, false, false},
            new bool[] {true, true, false},
            new bool[] {false, true, true}
        });
    }

    // PROTEINS

    public static BlockType chickenLeg() {
        return new BlockType("chicken leg", "¼¦ÍÈ", "protein", new bool[][] {
            new bool[] {true, false},
            new bool[] {true, true}
        });
    }

    public static BlockType tofu() {
        return new BlockType("tofu", "¶¹¸¯", "protein", new bool[][] {
            new bool[] {false, true, false},
            new bool[] {true, true, false},
            new bool[] {true, true, true}
        });
    }

    public static BlockType ham() {
        return new BlockType("ham", "»ðÍÈ", "protein", new bool[][] {
            new bool[] {true, true, true},
            new bool[] {false, true, true}
        });
    }

    public static BlockType egg() {
        return new BlockType("egg", "¼¦µ°", "protein", new bool[][] {
            new bool[] {false, false, true},
            new bool[] {false, false, true},
            new bool[] {true, true, true}
        });
    }

    public static BlockType fish() {
        return new BlockType("fish", "Óã", "protein", new bool[][] {
            new bool[] {true, true, false},
            new bool[] {false, true, true}
        });
    }

    public static BlockType fishSlice() {
        return new BlockType("fish slice", "ÓãÈâ", "protein", new bool[][] {
            new bool[] {false, true, true},
            new bool[] {true, true, false},
            new bool[] {true, false, false}
        });
    }

    public static BlockType bean() {
        return new BlockType("beans", "¶¹×Ó", "protein", new bool[][] {
            new bool[] {true, true},
            new bool[] {true, true}
        });
    }

    public static BlockType bacon() {
        return new BlockType("bacon", "Åà¸ù", "protein", new bool[][] {
            new bool[] {true},
            new bool[] {true}
        });
    }

    public static BlockType cheese() {
        return new BlockType("cheese", "ÄÌÀÒ", "protein", new bool[][] {
            new bool[] {true, true, true},
            new bool[] {true, true, true}
        });
    }
}