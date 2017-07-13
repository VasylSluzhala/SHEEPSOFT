var RevolutionSlider = function() {

  return {

    //Revolution Slider - Full Screen
    initRSfullScreen: function() {
      var revapi;
      jQuery(document).ready(function() {
        revapi = jQuery('.fullscreenbanner').revolution(
          {
            startwidth: 1170,
            startheight: 500,
            hideThumbs: -1,
            fullWidth: "on",
            fullScreen: "on",
            hideCaptionAtLimit: "",
            dottedOverlay: "twoxtwo",
            navigationStyle: "preview4",
            fullScreenOffsetContainer: "",
            stopAtSlide: 1,							// Stop Timer if Slide "x" has been Reached. If stopAfterLoops set to 0, then it stops already in the first Loop at slide X which defined. -1 means do not stop at any slide. stopAfterLoops has no sinn in this case.
            stopAfterLoops: 0                       // Stop Timer if All slides has been played "x" times. IT will stop at THe slide which is defined via stopAtSlide:x, if set to -1 slide never stop automatic
          });
      });
    }

  };
}();
