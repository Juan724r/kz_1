import PySimpleGUI as sg
import io
from PIL import Image

def main():
    # Описываем макет окна
    layout = [
        [sg.Button("Загрузить изображение")],
        [sg.Image(key="-IMAGE-")],
        [sg.Button("Кнопка 1"), sg.Button("Кнопка 2"), sg.Button("Кнопка 3"), sg.Button("Кнопка 4"), sg.Button("Кнопка 5")]
    ]

    # Создаем окно приложения
    window = sg.Window("Приложение с изображением", layout)

    while True:
        event, values = window.read()

        # Проверяем события
        if event == sg.WINDOW_CLOSED:
            break
        elif event == "Загрузить изображение":
            # Диалоговое окно для выбора файла
            filename = sg.popup_get_file("Выберите изображение")

            if filename:
                # Отображаем изображение
                image = Image.open(filename)
                image.thumbnail((400, 400))  # Масштабируем изображение, чтобы оно влезло в окно
                bio = io.BytesIO()
                image.save(bio, format="PNG")
                window["-IMAGE-"].update(data=bio.getvalue())

    window.close()

if __name__ == "__main__":
    main()
