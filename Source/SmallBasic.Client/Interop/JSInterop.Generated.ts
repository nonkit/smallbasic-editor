/*!
 * Licensed under the MIT License. See LICENSE file in the project root for license information.
 */

/// <summary>
/// This file is auto-generated by a build task. It shouldn't be edited by hand.
/// </summary>
import { LayoutInterop } from "./LayoutInterop";
import { MonacoInterop } from "./MonacoInterop";

export interface ILayoutInterop {
    initializeWebView(locale: string, title: string): Promise<void>;
    openExternalLink(url: string): Promise<void>;
    showMessage(title: string, text: string): Promise<void>;
    getElementHeight(element: HTMLElement): Promise<number>;
    getElementWidth(element: HTMLElement): Promise<number>;
    scrollIntoView(element: HTMLElement): Promise<void>;
    focus(element: HTMLElement): Promise<void>;
}

export interface IMonacoInterop {
    initialize(editorElement: HTMLElement, initialValue: string, isReadOnly: boolean): Promise<void>;
    dispose(): Promise<void>;
    selectRange(range: monaco.IRange): Promise<void>;
    highlightLine(line: number): Promise<void>;
    removeDecorations(): Promise<void>;
    saveToFile(): Promise<void>;
    openFile(confirmationMessage: string): Promise<void>;
    clearEditor(confirmationMessage: string): Promise<void>;
    cut(): Promise<void>;
    copy(): Promise<void>;
    paste(): Promise<void>;
    undo(): Promise<void>;
    redo(): Promise<void>;
}

declare global {
    export module JSInterop {
        export const Layout: ILayoutInterop;
        export const Monaco: IMonacoInterop;
    }
}

const layout: ILayoutInterop = new LayoutInterop();
const monaco: IMonacoInterop = new MonacoInterop();

(<any>global).JSInterop = {
    Layout: {
        initializeWebView: async (locale: string, title: string) : Promise<boolean> => {
            await layout.initializeWebView(locale, title);
            return true;
        },
        openExternalLink: async (url: string) : Promise<boolean> => {
            await layout.openExternalLink(url);
            return true;
        },
        showMessage: async (title: string, text: string) : Promise<boolean> => {
            await layout.showMessage(title, text);
            return true;
        },
        getElementHeight: async (element: HTMLElement) : Promise<number> => {
            return await layout.getElementHeight(element);
        },
        getElementWidth: async (element: HTMLElement) : Promise<number> => {
            return await layout.getElementWidth(element);
        },
        scrollIntoView: async (element: HTMLElement) : Promise<boolean> => {
            await layout.scrollIntoView(element);
            return true;
        },
        focus: async (element: HTMLElement) : Promise<boolean> => {
            await layout.focus(element);
            return true;
        }
    },
    Monaco: {
        initialize: async (editorElement: HTMLElement, initialValue: string, isReadOnly: boolean) : Promise<boolean> => {
            await monaco.initialize(editorElement, initialValue, isReadOnly);
            return true;
        },
        dispose: async () : Promise<boolean> => {
            await monaco.dispose();
            return true;
        },
        selectRange: async (range: monaco.IRange) : Promise<boolean> => {
            await monaco.selectRange(range);
            return true;
        },
        highlightLine: async (line: number) : Promise<boolean> => {
            await monaco.highlightLine(line);
            return true;
        },
        removeDecorations: async () : Promise<boolean> => {
            await monaco.removeDecorations();
            return true;
        },
        saveToFile: async () : Promise<boolean> => {
            await monaco.saveToFile();
            return true;
        },
        openFile: async (confirmationMessage: string) : Promise<boolean> => {
            await monaco.openFile(confirmationMessage);
            return true;
        },
        clearEditor: async (confirmationMessage: string) : Promise<boolean> => {
            await monaco.clearEditor(confirmationMessage);
            return true;
        },
        cut: async () : Promise<boolean> => {
            await monaco.cut();
            return true;
        },
        copy: async () : Promise<boolean> => {
            await monaco.copy();
            return true;
        },
        paste: async () : Promise<boolean> => {
            await monaco.paste();
            return true;
        },
        undo: async () : Promise<boolean> => {
            await monaco.undo();
            return true;
        },
        redo: async () : Promise<boolean> => {
            await monaco.redo();
            return true;
        }
    }
};
