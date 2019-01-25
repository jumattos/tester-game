import Interactive from './Interactive'

export default class Dialog implements Interactive {
    interact(): void {
        console.log("Hi, I am a dialog!");
    }
}