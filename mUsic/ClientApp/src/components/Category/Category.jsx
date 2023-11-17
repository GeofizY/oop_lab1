import React from 'react'
import CategoryStyle from './Category.module.scss'

const Category = (props) => {
    return (
        <li className={CategoryStyle.category}>{props.firstCategory}
            <ul className={CategoryStyle.subcategoryList}>
                <li className={CategoryStyle.subcategory}>{props.firstSubcategory}</li>
                <li className={CategoryStyle.subcategory}>{props.secondSubcategory}</li>
                <li className={CategoryStyle.subcategory}>{props.thirdSubcategory}</li>
            </ul>
        </li>
    )
}

export default Category