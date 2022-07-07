namespace Watykanczyk.Memes;

using System.Windows.Forms;
using Watykanczyk.Properties;

class Meme {
  private static Bitmap[] memes = new Bitmap[] {
    Resources.IMG_01,
    Resources.IMG_02,
    Resources.IMG_03,
    Resources.IMG_04,
    Resources.IMG_05,
    Resources.IMG_06,
    Resources.IMG_07,
    Resources.IMG_08,
    Resources.IMG_09,
    Resources.IMG_10,
    Resources.IMG_11,
    Resources.IMG_12,
    Resources.IMG_13,
    Resources.IMG_14,
    Resources.IMG_15,
    Resources.IMG_16,
    Resources.IMG_17,
    Resources.IMG_18,
    Resources.IMG_19,
    Resources.IMG_20,
    Resources.IMG_21,
    Resources.IMG_22,
    Resources.IMG_23,
    Resources.IMG_24,
    Resources.IMG_25,
    Resources.IMG_26,
    Resources.IMG_27,
    Resources.IMG_28,
    Resources.IMG_29,
    Resources.IMG_30,
    Resources.IMG_31,
    Resources.IMG_32,
    Resources.IMG_33,
    Resources.IMG_34,
    Resources.IMG_35,
    Resources.IMG_36,
    Resources.IMG_37,
    Resources.IMG_38,
    Resources.IMG_39,
    Resources.IMG_40,
    Resources.IMG_41,
    Resources.IMG_42,
    Resources.IMG_43,
    Resources.IMG_44,
    Resources.IMG_45,
    Resources.IMG_46,
    Resources.IMG_47,
    Resources.IMG_48,
    Resources.IMG_49,
    Resources.IMG_50,
    Resources.IMG_51,
    Resources.IMG_52,
    Resources.IMG_53,
    Resources.IMG_54,
    Resources.IMG_55,
    Resources.IMG_56,
  };

  public static Bitmap New() {
    int length = memes.Length;

    Random random = new Random();
    int r = random.Next(0, length - 1);

    return memes[r];
  }
}