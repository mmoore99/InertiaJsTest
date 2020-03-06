/* eslint-disable */

export const store = {
    debug: true,
    state: {
        currentPage: "Home/Index"
    },
    setCurrentPageAction(newValue) {
        if (this.debug) console.log("setCurrentPageAction triggered with", newValue);
        this.state.currentPage = newValue;
    },
    clearCurrentPageAction() {
        if (this.debug) console.log("clearCurrentPageAction triggered");
        this.state.message = "";
    }
};
